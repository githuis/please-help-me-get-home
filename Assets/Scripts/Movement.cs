using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    private Rigidbody rbd;

    [Range(0, 1000)] public float movementSpeed;
    [Range(0, 50)] public float dashDistance;
    [Range(0.0f, 5f)] public float hideMargin;
    public UiController uiController;

    private Vector3 movement;
    private Camera main;

    private float spd;
    private PlayerControl _playerControl;
    private bool dashing = false;
    private float timeSinceLastDash, dashCooldown = 1f, rotTime = 0f;
    public bool canDash => (dashing || timeSinceLastDash < dashCooldown);

    private bool hasTarget = false;
    private bool killPressed = false;
    private Enemy target;

    private bool standingStill = false;
    private float stillTime = 0f;

    private PlayerManager pm;
    public PlayerManager GetPlayer => pm;

    public bool hidden => stillTime >= hideMargin;
    private bool playedInvisSound;

    [FormerlySerializedAs("findDashables")]
    public FindKillableEnemy findKillables;

    private MeshRenderer _renderer, _pumpRenderer;
    public GameObject ghostBody, pumpkinBody;
    public Material visibleMaterial, invisibleMaterial;
    public Material[] pumpkinVisible, pumpkinInvis;
    public Light light;
    private float originalIntensity, invisIntensity;


    public ParticleSpawner _killSpawner;

    private Jukebox jq;

    void Awake()
    {
        rbd = GetComponent<Rigidbody>();
        main = Camera.main;
        _renderer = ghostBody.GetComponent<MeshRenderer>();
        _pumpRenderer = pumpkinBody.GetComponent<MeshRenderer>();

        pm = GetComponent<PlayerManager>();


        movement = Vector2.zero;

        _playerControl = new PlayerControl();

        _playerControl.Playermap.Move.performed += context => movement = context.ReadValue<Vector2>();
        _playerControl.Playermap.Move.started += context => movement = context.ReadValue<Vector2>();
    }

    private void Start()
    {
        jq = FindObjectOfType<Jukebox>();
        

        originalIntensity = light.intensity;
        invisIntensity = originalIntensity / 2;
    }

    void Update()
    {
        if (pm.isDead)
            return;


        Mover(movement);
        Kill();
        Rotator();

        if (standingStill)
            stillTime += Time.deltaTime;


        MaterialReplacer();

        timeSinceLastDash += Time.deltaTime;
    }

    private void MaterialReplacer()
    {
        if (hidden)
        {
            if (!playedInvisSound)
            {
                playedInvisSound = true;
                jq.PlayInvisWoosh();
            }
            _renderer.material = invisibleMaterial;
            _pumpRenderer.materials = pumpkinInvis;
            light.intensity = invisIntensity;
            uiController.ShowHiddenImg();
            if (!hasTarget)
                GetTarget(true);
        }
        else
        {
            playedInvisSound = false;
            _renderer.material = visibleMaterial;
            _pumpRenderer.materials = pumpkinVisible;
            light.intensity = originalIntensity;
            uiController.HideHiddenImg();


        }
    }

    public void OnMove(InputValue value)
    {
        Vector2 inputVal = value.Get<Vector2>();
        rotTime = 0;
        if (Math.Abs(inputVal.magnitude) < 0.21f)
        {
            standingStill = true;
        }
        else
        {
            standingStill = false;
            stillTime = 0;
        }

        movement = new Vector3(inputVal.x, -0.2f, inputVal.y);
    }

    public void OnDash()
    {
        if (canDash)
            return;
        timeSinceLastDash = 0;
        jq.PlayDash();

        rbd.AddForce(movement * dashDistance, ForceMode.Impulse);
        dashing = true;
        StartCoroutine(StopDashing());
    }

    private void Mover(Vector2 i)
    {
        if (dashing)
            return;

        spd = (Time.deltaTime * movementSpeed);
        Vector3 input = movement.normalized * spd;


        rbd.velocity = input;
    }

    void Rotator()
    {
        rotTime += Time.deltaTime * 0.5f;
        if (!standingStill && rbd.velocity != Vector3.zero)
        {
            Quaternion q = Quaternion.LookRotation(rbd.velocity);
            Vector3 v = q.eulerAngles;
            v.x = 0;
            //transform.rotation = Quaternion.Euler(v);
            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(v), Time.deltaTime * 1000);
        }
    }

    IEnumerator StopDashing()
    {
        OnPostDash();
        yield return new WaitForSeconds(0.15f);
        dashing = false;
        OnPostDash();
    }

    void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnPostDash()
    {
        GetTarget();
    }

    private void GetTarget(bool expires = true)
    {
        if (findKillables.SingleEnemy)
        {
            uiController.ShowKillButton();
            hasTarget = true;
            target = findKillables.GetSingleEnemy.GetComponent<Enemy>();
            if (expires)
                StartCoroutine(ExpireKillPossibility());
        }
    }

    IEnumerator ExpireKillPossibility()
    {
        yield return new WaitForSeconds(0.4f);
        ResetKill();
    }

    private void ResetKill()
    {
        killPressed = false;
        hasTarget = false;
        target = null;
        uiController.HideKillButton();
    }

    private void Kill()
    {
        if (killPressed && hasTarget)
        {
            jq.PlayEnemyDie();
            target.KillMe();
            ResetKill();
            //Rest dash
            dashing = false;
            timeSinceLastDash += 10;
            _killSpawner.Spawn();
        }
    }

    public void OnTakedown()
    {
        if (hasTarget)
            killPressed = true;
    }
}
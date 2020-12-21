using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class CanvasStore : MonoBehaviour
{
    public Image textBg;
    public Text txt;
    public Image killImg;
    public Image dashImg;
    public Image hiddenImage;

    public Text gemsText;
    public int totalGems;
    private Gemstone[] _gemstones;

    // Start is called before the first frame update
    void Start()
    {
        _gemstones = FindObjectsOfType<Gemstone>();
        totalGems = _gemstones.Length;
        StartCoroutine(SetGemsText());
        gemsText.text = $"{_gemstones.Count(gem => gem.hasBeenClaimed)} / {totalGems}";      

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SetGemsText()
    {
        yield return new WaitForSeconds(0.5f);
        gemsText.text = $"{_gemstones.Count(gem => gem.hasBeenClaimed)} / {totalGems}";      
        StartCoroutine(SetGemsText());

    }
}

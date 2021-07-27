using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PixelCrushers.DialogueSystem;

public class ChangeLanguage : MonoBehaviour
{
    public int currentOption = 0;

    [SerializeField] private Button languageButton;

    [SerializeField] private Sprite ENSprite;
    [SerializeField] private Sprite TRSprite;
    [SerializeField] private Sprite RUSprite;
    [SerializeField] private Sprite FRSprite;
    [SerializeField] private Sprite ITSprite;
    [SerializeField] private Sprite DESprite;
    [SerializeField] private Sprite ESSprite;
    [SerializeField] private Sprite JPSprite;
    [SerializeField] private Sprite KOSprite;
    [SerializeField] private Sprite PTSprite;
    [SerializeField] private Sprite ZHSprite;

    string languageString;

    [SerializeField] private Sprite[] languageSprites;

    // Start is called before the first frame update
    void Start()
    {
        //previousButton.onClick.AddListener(() => myButtonClick(currentOption--));
        languageButton.onClick.AddListener(() => myButtonClick(currentOption++));
        //DontDestroyOnLoad(this.gameObject);

        //GetComponentInChildren<Image>().sprite = Resources.Load(PlayerPrefs.GetString("languageString", languageString)) as Sprite;

        currentOption = PlayerPrefs.GetInt("currentOption", 0);
        myButtonClick(currentOption);
    }

    private void Update()
    {
        if (currentOption < 0 || currentOption > 10)
        {
            currentOption = 0;
        }
    }

    /*
    public static void WriteTextureToPlayerPrefs(string tag, Texture2D tex)
    {
        // if texture is png otherwise you can use tex.EncodeToJPG().
        byte[] texByte = tex.EncodeToPNG();

        // convert byte array to base64 string
        string base64Tex = System.Convert.ToBase64String(texByte);

        // write string to playerpref
        PlayerPrefs.SetString(tag, base64Tex);
        PlayerPrefs.Save();
    }

    public static Texture2D ReadTextureFromPlayerPrefs(string tag)
    {
        // load string from playerpref
        string base64Tex = PlayerPrefs.GetString(tag, null);

        if (!string.IsNullOrEmpty(base64Tex))
        {
            // convert it to byte array
            byte[] texByte = System.Convert.FromBase64String(base64Tex);
            Texture2D tex = new Texture2D(2, 2);

            //load texture from byte array
            if (tex.LoadImage(texByte))
            {
                return tex;
            }
        }

        return null;
    }
    */

    void Save()
    {
        languageString = GetComponentInChildren<Image>().sprite.name;
        PlayerPrefs.SetString("languageString", languageString);
        PlayerPrefs.SetInt("currentOption", currentOption);
        Debug.Log(languageString + " stored.");
    }

    public void myButtonClick(int optionValue)
    {
        switch (currentOption)
        {
            case 0:
                Debug.Log("English");
                languageButton.GetComponent<Image>().sprite = ENSprite;
                DialogueManager.SetLanguage("en");
                Save();
                optionValue++;
                break;

            case 1:
                Debug.Log("Russian");
                languageButton.GetComponent<Image>().sprite = RUSprite;
                DialogueManager.SetLanguage("ru");
                Save();

                optionValue++;
                break;

            case 2:
                Debug.Log("Turkish");
                languageButton.GetComponent<Image>().sprite = TRSprite;
                DialogueManager.SetLanguage("tr");
                Save();

                optionValue++;
                break;
            case 3:
                Debug.Log("French");
                languageButton.GetComponent<Image>().sprite = FRSprite;
                DialogueManager.SetLanguage("fr");
                Save();

                optionValue++;
                break;
            case 4:
                Debug.Log("Italien");
                languageButton.GetComponent<Image>().sprite = ITSprite;
                DialogueManager.SetLanguage("it");
                Save();

                optionValue++;
                break;
            case 5:
                Debug.Log("German");
                languageButton.GetComponent<Image>().sprite = DESprite;
                DialogueManager.SetLanguage("de");
                Save();

                optionValue++;
                break;
            case 6:
                Debug.Log("Spanish");
                languageButton.GetComponent<Image>().sprite = ESSprite;
                DialogueManager.SetLanguage("es");
                Save();

                optionValue++;
                break;
            case 7:
                Debug.Log("Portuguese - Brazil");
                languageButton.GetComponent<Image>().sprite = PTSprite;
                DialogueManager.SetLanguage("pt");
                Save();

                optionValue++;
                break;
            case 8:
                Debug.Log("Japanese");
                languageButton.GetComponent<Image>().sprite = JPSprite;
                DialogueManager.SetLanguage("jp");
                Save();

                optionValue++;
                break;
            case 9:
                Debug.Log("Korean");
                languageButton.GetComponent<Image>().sprite = KOSprite;
                DialogueManager.SetLanguage("ko");
                Save();

                optionValue++;
                break;
            case 10:
                Debug.Log("Simplified Chinese");
                languageButton.GetComponent<Image>().sprite = ZHSprite;
                DialogueManager.SetLanguage("zh");
                Save();

                optionValue++;
                break;
        }
    }

    void setButtonText(string buttonText)
    {
        languageButton.transform.GetChild(0).GetComponent<Text>().text = buttonText;
    }
}

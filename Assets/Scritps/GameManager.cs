using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public CustomDoubleLinkedList list = new CustomDoubleLinkedList();
    public TextMeshProUGUI TextHudName;
    public TextMeshProUGUI Textdialo;
    public Node<Dialogo> current;
    public bool OnWrite = false;
    public GameObject Hud;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    }
    void Start()
    {
        list.AddNode(new Dialogo("chara", ".........................", Emotion.Happy,0.1f));
        list.AddNode(new Dialogo("Sans", "Es un dia hermoso alla afuera", Emotion.Happy,0.3f));
        list.AddNode(new Dialogo("Sans", "Las aves cantan, las flores florecen....", Emotion.Happy,0.1f));
        list.AddNode(new Dialogo("Sans", "Asi niños como tu ......", Emotion.Angry,0.2f));
        list.AddNode(new Dialogo("Sans", "deberian arder en el infierno", Emotion.Angry, 0.4f));
        current = list.Tail;
        Read();
    }
    public void Read()
    {
        if (current == null) return;
        StartCoroutine(list.ReadText(current,TextHudName,Textdialo));
    }
   public void Changebool(bool change)
    {
        OnWrite = change;
    }
    public void Next()
    {
        if (current != null && current.Next != null && OnWrite == false)
        {
            OnWrite = true;
            current = current.Next;
            Read();

        }
    }
    public void Prev()
    {
        if (current != null && current.Prev != null && OnWrite == false)
        {
            OnWrite = true;
            current = current.Prev;
            Read();
           
        }
        
    }
}

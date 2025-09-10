using UnityEngine;

public enum Emotion
{
    None,
    Happy,
    Angry,
    Scared,

}
public class Dialogo
{
    public string Name;
    public string Texto;
    public float Velocity;
    public Emotion emotion;
    public Dialogo(string Name, string Text, Emotion emotion, float velocity)
    {
        this.Name = Name;
        Texto = Text;
        this.emotion = emotion;
        Velocity = velocity;
    }

    public string GetDialog( out Emotion emotion)
    {
        emotion = this.emotion;
        return Texto;
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_logic : MonoBehaviour
{
    public InputField userinput;
    public Text gamelabel;
    public int random;
    // Start is called before the first frame update
    void Start()
    {
        random=randomno(0,21);
        gamelabel.text="Guess a Number between 0 to 20";
        Debug.Log(random);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonclick(){
        string userinputValue=userinput.text;
        if(userinputValue !=""){
        int answer = int.Parse(userinputValue);
            if (answer == random){
                gamelabel.text="Right";
            }
            else if(answer > random){
                gamelabel.text="Enter value is bigger then guess";
            }
            else {
                gamelabel.text="try higher";
            }
        }
        else{
            Debug.Log("no");
        }
    }

    private int randomno(int min, int max){
        int randomn=Random.Range(min,max);
        return randomn;
    }
}

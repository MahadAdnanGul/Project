using Gamekit2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    bool used = false;
    bool used2 = false;
    // Start is called before the first frame update
    public void exiting(int choice)
    {
        if(choice ==1)
        {
            
            SceneManager.LoadScene("Khoka_transition");
        }
        
        else if(choice ==-1)
        {
            
            SceneManager.LoadScene("SampleScene");
            
        }
        else if(choice==2)
        {
            SceneManager.LoadScene("acd_block");
        }
        else if (choice == 3)
        {
            SceneManager.LoadScene("stress");
        }
        else if (choice == 4)
        {
            SceneManager.LoadScene("aftermath");
        }
        else if (choice == 5)
        {
            SceneManager.LoadScene("Law_school");
        }
        else if (choice == 6)
        {
            SceneManager.LoadScene("SSE1");
        }
        else if (choice == 7)
        {
            SceneManager.LoadScene("sse2");
        }
        else if (choice == 8)
        {
            SceneManager.LoadScene("SSE3");
        }
        else if (choice == 9)
        {
            SceneManager.LoadScene("SSE_COVER");
        }
        else if (choice == 10)
        {
            SceneManager.LoadScene("SSE_Schedule");
        }

    }
    public void obj_changeD()
    {


        FindObjectOfType<Objectives>().change_obj();
    } 

        
    public void obj_change()
    {
        if(used==false)
        {
            FindObjectOfType<Objectives>().change_obj();
            used = true;

        }
        
    }
    public void obj_change2()
    {
        if (used2 == false)
        {
            FindObjectOfType<Objectives>().change_obj();
            used2 = true;

        }
    }
}

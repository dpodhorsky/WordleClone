using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WordleGame : MonoBehaviour
{
    private string guess1,guess2,guess3,guess4,guess5;
    private string answer = "boost";
    private string guessedWord;
    private int guessCounter = 0;
    private int answerGuess = 1;
    private string letter1, letter2, letter3, letter4, letter5;
    public Button Keyboard_Q,Keyboard_W,Keyboard_E,Keyboard_R,Keyboard_T,Keyboard_Y,Keyboard_U,Keyboard_I,Keyboard_O,Keyboard_P,
    Keyboard_A,Keyboard_S,Keyboard_D,Keyboard_F,Keyboard_G,Keyboard_H,Keyboard_J,Keyboard_K,Keyboard_L,
    Keyboard_Z,Keyboard_X,Keyboard_C,Keyboard_V,Keyboard_B,Keyboard_N,Keyboard_M,SubmitButton,DeleteButton;

    public Button g1l1, g1l2, g1l3, g1l4, g1l5,
                  g2l1, g2l2, g2l3, g2l4, g2l5,
                  g3l1, g3l2, g3l3, g3l4, g3l5,
                  g4l1, g4l2, g4l3, g4l4, g4l5,
                  g5l1, g5l2, g5l3, g5l4, g5l5,
                  g6l1, g6l2, g6l3, g6l4, g6l5;
    public Button _tmp;
    public Sprite CorrertSpot, WrongSpot, WrongLetter;

    public Canvas winner;


    // Start is called before the first frame update
    void Start()
    {

       // winner.SetActive(false);
        Debug.Log("Running");

        
        Button btnW = Keyboard_W.GetComponent<Button>();
        Button btnQ = Keyboard_Q.GetComponent<Button>();
        Button btnE = Keyboard_E.GetComponent<Button>();
        Button btnR = Keyboard_R.GetComponent<Button>();
        Button btnT = Keyboard_T.GetComponent<Button>();
        Button btnY = Keyboard_Y.GetComponent<Button>();
        Button btnU = Keyboard_U.GetComponent<Button>();
        Button btnI = Keyboard_I.GetComponent<Button>();
        Button btnO = Keyboard_O.GetComponent<Button>();
        Button btnP = Keyboard_P.GetComponent<Button>();
        Button btnA = Keyboard_A.GetComponent<Button>();
        Button btnS = Keyboard_S.GetComponent<Button>();
        Button btnD = Keyboard_D.GetComponent<Button>();
        Button btnF = Keyboard_F.GetComponent<Button>();
        Button btnG = Keyboard_G.GetComponent<Button>();
        Button btnH = Keyboard_H.GetComponent<Button>();
        Button btnJ = Keyboard_J.GetComponent<Button>();
        Button btnK = Keyboard_K.GetComponent<Button>();
        Button btnL = Keyboard_L.GetComponent<Button>();
        Button btnZ = Keyboard_Z.GetComponent<Button>();
        Button btnX = Keyboard_X.GetComponent<Button>();
        Button btnC = Keyboard_C.GetComponent<Button>();
        Button btnV = Keyboard_V.GetComponent<Button>();
        Button btnB = Keyboard_B.GetComponent<Button>();
        Button btnN = Keyboard_N.GetComponent<Button>();
        Button btnM = Keyboard_M.GetComponent<Button>();
        Button btnSubmit = SubmitButton.GetComponent<Button>();
        Button btnDelete = DeleteButton.GetComponent<Button>();

       


        btnW.onClick.AddListener(W_OnCLick);
        btnQ.onClick.AddListener(Q_OnCLick);
        btnE.onClick.AddListener(E_OnCLick);
        btnR.onClick.AddListener(R_OnCLick);
        btnT.onClick.AddListener(T_OnCLick);
        btnY.onClick.AddListener(Y_OnCLick);
        btnU.onClick.AddListener(U_OnCLick);
        btnI.onClick.AddListener(I_OnCLick);
        btnO.onClick.AddListener(O_OnCLick);
        btnP.onClick.AddListener(P_OnCLick);
        btnA.onClick.AddListener(A_OnCLick);
        btnS.onClick.AddListener(S_OnCLick);
        btnD.onClick.AddListener(D_OnCLick);
        btnF.onClick.AddListener(F_OnCLick);
        btnG.onClick.AddListener(G_OnCLick);
        btnH.onClick.AddListener(H_OnCLick);
        btnJ.onClick.AddListener(J_OnCLick);
        btnK.onClick.AddListener(K_OnCLick);
        btnL.onClick.AddListener(L_OnCLick);
        btnZ.onClick.AddListener(Z_OnCLick);
        btnX.onClick.AddListener(X_OnCLick);
        btnC.onClick.AddListener(C_OnCLick);
        btnV.onClick.AddListener(V_OnCLick);
        btnB.onClick.AddListener(B_OnCLick);
        btnN.onClick.AddListener(N_OnCLick);
        btnM.onClick.AddListener(M_OnCLick);
        btnSubmit.onClick.AddListener(Submit_OnClick);
        btnDelete.onClick.AddListener(Delete_OnClick);



        

    }

    //  GuessLetter is called once per frame
    void GuessLetter(string letter)
    {
        string pressedLetter = letter;

        //Debug.Log("Guessed Letter: " + pressedLetter);
        //Text guess = g1l1.GetComponentInChildren<Text>();
        //guess.text = pressedLetter;
        //Debug.Log("################################");
       // Debug.Log("Guess Counter: " + guessCounter);
       // Debug.Log("Answer Guess: " + answerGuess);
       // Debug.Log("Button Ref: G" + answerGuess + "L" + guessCounter);
        switch(guessCounter)
        {
            case 0:
                //Text guess = g2l1.GetComponentInChildren<Text>();
                _tmp = GameObject.Find("G" + answerGuess + "L1").GetComponent<Button>();
                Text guess = _tmp.GetComponentInChildren<Text>();
                guess.text = pressedLetter;
                guessCounter++;
                break;
            case 1:
                _tmp = GameObject.Find("G" + answerGuess + "L2").GetComponent<Button>();
                Text guess2 = _tmp.GetComponentInChildren<Text>();
                guess2.text = pressedLetter;
                guessCounter++;
                break;
            case 2:
                _tmp = GameObject.Find("G" + answerGuess + "L3").GetComponent<Button>();
                Text guess3 = _tmp.GetComponentInChildren<Text>();
                guess3.text = pressedLetter;
                guessCounter++;
                break;
            case 3:
                _tmp = GameObject.Find("G" + answerGuess + "L4").GetComponent<Button>();
                Text guess4 = _tmp.GetComponentInChildren<Text>();
                guess4.text = pressedLetter;
                guessCounter++;
                break;
            case 4:
                _tmp = GameObject.Find("G" + answerGuess + "L5").GetComponent<Button>();
                Text guess5 = _tmp.GetComponentInChildren<Text>();
                guess5.text = pressedLetter;
                guessCounter++;
                break;
            default:
                //Debug.Log("Default Case");
                break;
        }
        
    }

    void Delete_OnClick()
    {
      //  Debug.Log("Delete Button Pressed");
     //   Debug.Log("---- " + guessCounter);
        //if (guessCounter == 0) { Debug.Log("!!!!"); return; }

        switch (guessCounter)
        {
            case 1:
                Debug.Log("Delete Case 0");
                _tmp = GameObject.Find("G" + answerGuess + "L1").GetComponent<Button>();
                Text guess = _tmp.GetComponentInChildren<Text>();
                guess.text = "";
                guessCounter--;
                break;
            case 2:
                _tmp = GameObject.Find("G" + answerGuess + "L2").GetComponent<Button>();
                Text guess2 = _tmp.GetComponentInChildren<Text>();
                guess2.text = "";
                guessCounter--;
                break;
            case 3:
                _tmp = GameObject.Find("G" + answerGuess + "L3").GetComponent<Button>();
                Text guess3 = _tmp.GetComponentInChildren<Text>();
                guess3.text = "";
                guessCounter--;
                break;
            case 4:
                _tmp = GameObject.Find("G" + answerGuess + "L4").GetComponent<Button>();
                Text guess4 = _tmp.GetComponentInChildren<Text>();
                guess4.text = "";
                guessCounter--;
                break;
            case 5:
                _tmp = GameObject.Find("G" + answerGuess + "L5").GetComponent<Button>();
                Text guess5 = _tmp.GetComponentInChildren<Text>();
                guess5.text = "";
                guessCounter--;
                break;
            default:
                //Debug.Log("Default Case");
                break;
        }
        if (guessCounter < 0 )
        {
            guessCounter = 0;
        }
    }

    void Submit_OnClick()
    {
        if (guessCounter < 5)
        {
            //Debug.Log("FINISH GUESSING A WORD");
            return;
        }
        

        letter1 = GameObject.Find("G" + answerGuess + "L1").GetComponentInChildren<Text>().text.ToString();
        letter2 = GameObject.Find("G" + answerGuess + "L2").GetComponentInChildren<Text>().text.ToString();
        letter3 = GameObject.Find("G" + answerGuess + "L3").GetComponentInChildren<Text>().text.ToString();
        letter4 = GameObject.Find("G" + answerGuess + "L4").GetComponentInChildren<Text>().text.ToString();
        letter5 = GameObject.Find("G" + answerGuess + "L5").GetComponentInChildren<Text>().text.ToString();

        guessedWord = letter1 + letter2 + letter3 + letter4 + letter5;

        guessedWord = guessedWord.ToLower();

        //Debug.Log("Guessed Word -- " + guessedWord);

        Button firstLetter;

        for (int counter = 0; counter < 5; counter++)
        {
            //Debug.Log("Guessed Letter: " + guessedWord[counter].ToString());
            //Debug.Log("Answer  Letter: " + answer[counter].ToString());
            bool result = answer.Contains(guessedWord[counter].ToString());
            //Debug.Log(result);
            if (result == true)
            {
                switch (counter)
                {
                    case 0:
                       // g1l1.image.sprite = WrongSpot;
                        GameObject.Find("G"+answerGuess+"L1").GetComponent<Button>().image.sprite = WrongSpot;
                        GameObject.Find("Keyboard_" + letter1).GetComponent<Button>().image.sprite = WrongSpot;
                        break; 
                    case 1:
                       // g1l2.image.sprite = WrongSpot;
                        GameObject.Find("G" + answerGuess + "L2").GetComponent<Button>().image.sprite = WrongSpot;
                        GameObject.Find("Keyboard_" + letter2).GetComponent<Button>().image.sprite = WrongSpot;
                        break;
                    case 2:
                       // g1l3.image.sprite = WrongSpot;
                        GameObject.Find("G" + answerGuess + "L3").GetComponent<Button>().image.sprite = WrongSpot;
                        GameObject.Find("Keyboard_" + letter3).GetComponent<Button>().image.sprite = WrongSpot;
                        break;
                    case 3:
                       // g1l4.image.sprite = WrongSpot;
                        GameObject.Find("G" + answerGuess + "L4").GetComponent<Button>().image.sprite = WrongSpot;
                        GameObject.Find("Keyboard_" + letter4).GetComponent<Button>().image.sprite = WrongSpot;
                        break;
                    case 4:
                       // g1l5.image.sprite = WrongSpot;
                        GameObject.Find("G" + answerGuess + "L5").GetComponent<Button>().image.sprite = WrongSpot;
                        GameObject.Find("Keyboard_" + letter5).GetComponent<Button>().image.sprite = WrongSpot;
                        break;
                    default:
                        //Debug.Log("Default Case");
                        break;
                }
            } else
            {
                switch (counter)
                {
                    case 0:
                        GameObject.Find("G" + answerGuess + "L1").GetComponent<Button>().image.sprite = WrongLetter;
                        GameObject.Find("Keyboard_" + letter1).GetComponent<Button>().image.sprite = WrongLetter;
                        break;
                    case 1:
                        GameObject.Find("G" + answerGuess + "L2").GetComponent<Button>().image.sprite = WrongLetter;
                        GameObject.Find("Keyboard_" + letter2).GetComponent<Button>().image.sprite = WrongLetter;
                        break;
                    case 2:
                        GameObject.Find("G" + answerGuess + "L3").GetComponent<Button>().image.sprite = WrongLetter;
                        GameObject.Find("Keyboard_" + letter3).GetComponent<Button>().image.sprite = WrongLetter;
                        break;
                    case 3:
                        GameObject.Find("G" + answerGuess + "L4").GetComponent<Button>().image.sprite = WrongLetter;
                        GameObject.Find("Keyboard_" + letter4).GetComponent<Button>().image.sprite = WrongLetter;
                        break;
                    case 4:
                        GameObject.Find("G" + answerGuess + "L5").GetComponent<Button>().image.sprite = WrongLetter;
                        GameObject.Find("Keyboard_" + letter5).GetComponent<Button>().image.sprite = WrongLetter;
                        break;
                    default:
                        //Debug.Log("Default Case");
                        break;
                }
            }

            if (answer[counter].Equals(guessedWord[counter]))
            {
                switch (counter)
                {
                    case 0:
                        GameObject.Find("G" + answerGuess + "L1").GetComponent<Button>().image.sprite = CorrertSpot;
                        GameObject.Find("Keyboard_" + letter1).GetComponent<Button>().image.sprite = CorrertSpot;
                        break;
                    case 1:
                        GameObject.Find("G" + answerGuess + "L2").GetComponent<Button>().image.sprite = CorrertSpot;
                        GameObject.Find("Keyboard_" + letter2).GetComponent<Button>().image.sprite = CorrertSpot;
                        break;
                    case 2:
                        GameObject.Find("G" + answerGuess + "L3").GetComponent<Button>().image.sprite = CorrertSpot;
                        GameObject.Find("Keyboard_" + letter3).GetComponent<Button>().image.sprite = CorrertSpot;
                        break;
                    case 3:
                        GameObject.Find("G" + answerGuess + "L4").GetComponent<Button>().image.sprite = CorrertSpot;
                        GameObject.Find("Keyboard_" + letter4).GetComponent<Button>().image.sprite = CorrertSpot;
                        break;
                    case 4:
                        GameObject.Find("G" + answerGuess + "L5").GetComponent<Button>().image.sprite = CorrertSpot;
                        GameObject.Find("Keyboard_" + letter5).GetComponent<Button>().image.sprite = CorrertSpot;
                        break;
                    default:
                        //Debug.Log("Default Case");
                        break;

                }
            }
            

        }
        answerGuess++;
        guessCounter = 0;


        //Debug.Log(guessedWord);
        //Debug.Log(answer);

        if (guessedWord.Equals(answer))
        {
           // winner.SetActive(true);
            Debug.Log("You Won");
        }

        if ((answerGuess == 6) && (!guessedWord.Equals(answer)))
        {
            Debug.Log("You Lost");
        }
    }



    void Q_OnCLick() 
    {
        //Debug.Log("Keyboard Press: Q");
        GuessLetter("Q");
    }
    void W_OnCLick()
    {
        //Debug.Log("Keyboard Press: W");
        GuessLetter("W");
    }
    void E_OnCLick()
    {
        //Debug.Log("Keyboard Press: E");
        GuessLetter("E");
    }
    void R_OnCLick()
    {
        //Debug.Log("Keyboard Press: R");
        GuessLetter("R");
    }
    void T_OnCLick()
    {
        //Debug.Log("Keyboard Press: T");
        GuessLetter("T");
    }
    void Y_OnCLick()
    {
        //Debug.Log("Keyboard Press: Y");
        GuessLetter("Y");
    }
    void U_OnCLick()
    {
        //Debug.Log("Keyboard Press: U");
        GuessLetter("U");
    }
    void I_OnCLick()
    {
        //Debug.Log("Keyboard Press: I");
        GuessLetter("I");
    }
    void O_OnCLick()
    {
        //Debug.Log("Keyboard Press: O");
        GuessLetter("O");
    }
    void P_OnCLick()
    {
        //Debug.Log("Keyboard Press: P");
        GuessLetter("P");
    }
    void A_OnCLick()
    {
        //Debug.Log("Keyboard Press: A");
        GuessLetter("A");
    }
    void S_OnCLick()
    {
        //Debug.Log("Keyboard Press: S");
        GuessLetter("S");
    }
    void D_OnCLick()
    {
        //Debug.Log("Keyboard Press: D");
        GuessLetter("D");
    }
    void F_OnCLick()
    {
        //Debug.Log("Keyboard Press: F");
        GuessLetter("F");
    }
    void G_OnCLick()
    {
        //Debug.Log("Keyboard Press: G");
        GuessLetter("G");
    }
    void H_OnCLick()
    {
        //Debug.Log("Keyboard Press: H");
        GuessLetter("H");
    }
    void J_OnCLick()
    {
        //Debug.Log("Keyboard Press: J");
        GuessLetter("J");
    }
    void K_OnCLick()
    {
        //Debug.Log("Keyboard Press: K");
        GuessLetter("K");
    }
    void L_OnCLick()
    {
        //Debug.Log("Keyboard Press: L");
        GuessLetter("L");
    }
    void Z_OnCLick()
    {
        //Debug.Log("Keyboard Press: Z");
        GuessLetter("Z");
    }
    void X_OnCLick()
    {
        //Debug.Log("Keyboard Press: X");
        GuessLetter("X");
    }
    void C_OnCLick()
    {
        //Debug.Log("Keyboard Press: C");
        GuessLetter("C");
    }
    void V_OnCLick()
    {
        //Debug.Log("Keyboard Press: V");
        GuessLetter("V");
    }
    void B_OnCLick()
    {
        //Debug.Log("Keyboard Press: B");
        GuessLetter("B");
    }
    void N_OnCLick()
    {
        //Debug.Log("Keyboard Press: N");
        GuessLetter("N");
    }
    void M_OnCLick()
    {
        //Debug.Log("Keyboard Press: M");
        GuessLetter("M");
    }

}

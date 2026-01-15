using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Librería para poder acceder a los TextMeshPro
using UnityEngine.UI; //Librería para poder acceder a los componentes de la UI
//Variables son float, string, bull, char, ya que se guardan en referencia
//TextMeshProUGUI no es una variable

public class AdventureGameController : MonoBehaviour
{

   


    //Con esto podemos acceder al Texto de TextMeshPro de la UI
    [SerializeField] Image spriteComponent;
    
    [SerializeField] TextMeshProUGUI textComponent;

    

    // Variable de tipo State(clase State), que usamos para poder acceder a las variables y métodos del script State
    State state; //Este estado irá cambiando conforme avanza el juego

    //Será el estado inicial en el que empieza el juego
    [SerializeField] State startingState;

    void Start()
    {
        //El estado actual será el estado inicial del juego
        state = startingState;
        //Accedemos al componente text dentro del textComponent(StoryText) y metemos lo que haya dentro del campo del estado actual
        textComponent.text = state.GetStateStory();
        spriteComponent.sprite = state.GetStateSprite();

        //UIImagen = GameObject.Find("Imagen").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //Hacemos la llamada al método
        ManageState();

        //if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            //UIImagen.sprite = Resources.Load<Sprite>("Sprite Assets/1");
       // }
        //if(Input.GetKeyDown(KeyCode.Alpha1)){
            //UIImagen.sprite = Resources.Load<Sprite>("Sprite Assets/2");
        //}
    
    }

    //Método para manejar el cambio entre estados
    void ManageState()
    {
        //Generamos un array de estados, donde guardamos los estados a los que podemos ir desde el estado actual en el que estamos
        var nextStates = state.GetNextStates(); // <=> State[] nextStates = state.GetNextStates();

        //Con este for conseguimos mejorar lo abajo comentado
        for(int index = 0; index < nextStates.Length; index++)
        {
            //Alpha1 + index, cambiará de número que pulsar cada vez
            if(Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                //Irá al estado cuya posición sea el valor de index
                state = nextStates[index];
            }
        }
        //Si pulsamos la tecla 1 del teclado
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Del estado en el que esté pasa al siguiente estado que esté en la posición del array 0
            state = nextStates[0];
        }
        //Actualizamos el texto del juego, con el del siguiente estado
        textComponent.text = state.GetStateStory();
        spriteComponent.sprite = state.GetStateSprite();

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Del estado en el que esté pasa al siguiente estado que esté en la posición del array 1
            state = nextStates[1];
        }
        //Actualizamos el texto del juego, con el del siguiente estado
        textComponent.text = state.GetStateStory();
        spriteComponent.sprite = state.GetStateSprite();

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Del estado en el que esté pasa al siguiente estado que esté en la posición del array 2
           state = nextStates[2];
        }
        //Actualizamos el texto del juego, con el del siguiente estado
        textComponent.text = state.GetStateStory();
        spriteComponent.sprite = state.GetStateSprite();

        //Si pulsamos la tecla Enter del teclado
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            //Del estado en el que esté pasa al siguiente estado que esté en la posición del array 0
            state = nextStates[0];
        }
        //Actualizamos el texto del juego, con el del siguiente estado
        textComponent.text = state.GetStateStory();
        spriteComponent.sprite = state.GetStateSprite();

        //Si pulsamos la tecla Enter del teclado
        if (Input.GetKeyDown(KeyCode.F))
        {
            //Del estado en el que esté pasa al siguiente estado que esté en la posición del array 0
            state = nextStates[0];
        }
        //Actualizamos el texto del juego, con el del siguiente estado
        textComponent.text = state.GetStateStory();
        spriteComponent.sprite = state.GetStateSprite();
        }

        
}

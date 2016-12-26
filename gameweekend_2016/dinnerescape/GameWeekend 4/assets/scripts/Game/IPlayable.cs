using UnityEngine;
using System.Collections;

/*
 * Esta clase es la que manejará y decidirá qué objeto esta bajo control del jugador.
 */
public class IPlayable : IControllable {

    //Elemento bajo control actualmente
    private static IPlayable current;
    private static bool pAllowInput;

    protected Vector3 currentInput;

    public IPlayable() : base()
    {
        currentInput = new Vector2();
    }

    //Devuelve el objecto bajo control ahora mismo
    public static IPlayable getCurrent()
    {
        return current;
    }

    //Transfiere el control a la nueva entidad.
    public bool transferControl(IPlayable playable)
    {
        if (playable != null)
        {
            IPlayable.current = playable;
            return true;
        }
        else return false;
    }

    //Set user input
    public IPlayable allowInput(bool allow)
    {
        IPlayable.pAllowInput = allow;
        return this;
    }

    //Abstract call
    public virtual void OnInput(Vector3 input)
    {

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	private new void LateUpdate() {
        currentInput.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessModifier : MonoBehaviour
{

    //public - widoczne w inspektorze/widoczne w innych klasach
    //private - nie widoczne w inspektorze/nie widoczne w innych klasach
    //protected - nie widoczne w inspektorze/widoczne jedynie w klasach dziedzicz�cych
    //*internal - nie widoczny w inspektorze/widoczne w obr�bie jednego assembly
   

    public int m_Int = 0;
    private float m_Float = 0;
    protected int m_intPro = 1;
    internal int m_intInternal = 1;

    [SerializeField] private string m_String = "";  //[SerializeField] - atrybut dzi�ki kt�remu widzimy private zmienn� w inspektorze

    public int x_Int3 { get; set; } //Getter i setter w skr�cie, taki zapis nie jest widoczny w inspektorze
    [SerializeField] private int x_Int2 { get; set; } //Taki zapis atrybutu nie udost�pni nam widoczno�ci zmiennej w inspektorze
    [field: SerializeField] public int z_Int { get; set; } //Taki zapis atrybutu udost�pnia nam zmienn� w inspektorze

    public int x_Int { get => x_Int2; }
    public bool x_Ibool { get; private set; } = false;

    
    //Przy zmiennych gdzie wyst�puj� s�owo "new" zaleca si� implementacj� na starcie gry je�li jest to mo�liwe, NIE przy ka�dym wczytaniu zmiennej
    public WaitForSeconds wait; //Zalecane rozwi�zanie
    public WaitForSeconds wait2 => new WaitForSeconds(5);//Gorsze rozwi�zanie, przy ka�dym pobraniu tworzymy now� instacj�

    private void Awake()
    {
        wait = new WaitForSeconds(x_Int2);

        StartCoroutine(Timer(x_Int)); //W taki spos�b uruchamiamy func Coroutine
    }

    public IEnumerator Timer(float RANDOM)
    {
        //Logika

        //Odczekaj okre�lony czas
        yield return wait;

        //Logika po czasie
    }
}

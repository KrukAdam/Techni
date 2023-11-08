using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessModifier : MonoBehaviour
{

    //public - widoczne w inspektorze/widoczne w innych klasach
    //private - nie widoczne w inspektorze/nie widoczne w innych klasach
    //protected - nie widoczne w inspektorze/widoczne jedynie w klasach dziedzicz¹cych
    //*internal - nie widoczny w inspektorze/widoczne w obrêbie jednego assembly
   

    public int m_Int = 0;
    private float m_Float = 0;
    protected int m_intPro = 1;
    internal int m_intInternal = 1;

    [SerializeField] private string m_String = "";  //[SerializeField] - atrybut dziêki któremu widzimy private zmienn¹ w inspektorze

    public int x_Int3 { get; set; } //Getter i setter w skrócie, taki zapis nie jest widoczny w inspektorze
    [SerializeField] private int x_Int2 { get; set; } //Taki zapis atrybutu nie udostêpni nam widocznoœci zmiennej w inspektorze
    [field: SerializeField] public int z_Int { get; set; } //Taki zapis atrybutu udostêpnia nam zmienn¹ w inspektorze

    public int x_Int { get => x_Int2; }
    public bool x_Ibool { get; private set; } = false;

    
    //Przy zmiennych gdzie wystêpujê s³owo "new" zaleca siê implementacjê na starcie gry jeœli jest to mo¿liwe, NIE przy ka¿dym wczytaniu zmiennej
    public WaitForSeconds wait; //Zalecane rozwi¹zanie
    public WaitForSeconds wait2 => new WaitForSeconds(5);//Gorsze rozwi¹zanie, przy ka¿dym pobraniu tworzymy now¹ instacjê

    private void Awake()
    {
        wait = new WaitForSeconds(x_Int2);

        StartCoroutine(Timer(x_Int)); //W taki sposób uruchamiamy func Coroutine
    }

    public IEnumerator Timer(float RANDOM)
    {
        //Logika

        //Odczekaj okreœlony czas
        yield return wait;

        //Logika po czasie
    }
}

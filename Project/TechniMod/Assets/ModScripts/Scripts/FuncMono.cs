using UnityEngine;


namespace ModScripts
{
    public class FuncMono : MonoBehaviour
    {
        //Opis najwa�niejszych metod w MonoBehaviour
        //Pe�ny opis: https://mwin.pl/poznac-funkcje-unity/

        public GameObject prefab1;
        public Move prefab2;

        private void Awake()
        {
            //Funkcja, kt�ra wykonuje si� jako pierwsze,
            //zaraz gdy obiekt zostanie utworzony w scenie.
            //Jednak wykonuje si� tylko, gdy obiekt jest aktywny.
            //Je�li nie jest, to funkcja jest pierwsz�, kt�ra si� wykona,
            //gdy zostanie aktywowany

            var obj1 = Instantiate(prefab1);
            obj1.transform.position = Vector3.zero;
            obj1.GetComponent<Move>().speed = 1;

            var obj2 = Instantiate(prefab2);
            obj2.speed = 1.0f;


        }

        void Start()
        {
            //Wykonuje si� przed aktualizacj� pierwszej klatki.
            //Jedyna uwaga: instancja obiektu musi by� w��czona,
            //a skrypt aktywny. Gdy Awake traktujemy jako konstruktor,
            //to funkcje Start powinni�my wykorzysta� do utworzenia relacji
            //skryptu z pozosta�ymi.
        }

        private void OnEnable()
        {
            //Tutaj mo�na si� domy�li�, �e funkcja wykona si�,
            //gdy komponent zostanie aktywowany.
            //Funkcja wykona si� tylko dla komponent�w aktywnych.
            //Wykonuje si� przed funkcja start i w przeciwie�stwie do niej,
            //wykonuje si� przy ka�dej aktywacji komponentu.
        }

        private void OnDisable()
        {
            //Wywo�ane gdy obiekt posiadaj�cy skrypt stanie
            //wy��czony (disabled) albo nieaktywny (inactive).
        }

        private void OnCollisionEnter(Collision collision)
        {

            //W przeciwie�stwie do OnTriggerEnter,
            //OnCollisionEnter przekazuje klas� Collision,
            //a nie Collider. Klasa Collision zawiera informacje
            //m.in. o punktach styku i pr�dko�ci uderzenia.
            //Uwagi: Zdarzenia kolizji s� wysy�ane tylko wtedy,
            //gdy do jednego ze zderzaczy jest r�wnie� do��czony
            //non-kinematic rigidbody. Zdarzenia kolizyjne b�d�
            //wysy�ane do wy��czonych MonoBehaviours,
            //aby umo�liwi� w��czenie zachowa� w odpowiedzi na kolizje.
        }

        private void OnTriggerEnter(Collider other)
        {
        //OnTriggerEnter ma miejsce w przypadku funkcji FixUpdate,
        //gdy zderzaj� si� dwa obiekty GameObject.
        //Zaanga�owane Collidery nie zawsze znajduj�
        //si� w punkcie pierwszego kontaktu.

        //Uwaga: Oba obiekty GameObject musz� zawiera�
        //komponent Collider.Jeden musi mie� w��czony
        //Collider.isTrigger i zawiera� Rigidbody.
        //Je�li oba obiekty GameObject maj� w��czon� opcj�
        //Collider.isTrigger, nie dochodzi do kolizji.
        //To samo dotyczy sytuacji, gdy oba GameObjects
        //nie maj� komponentu Rigidbody.
        }

        private void OnTriggerExit(Collider other)
        {
            //OnTriiger czy OnCollision maj� r�wnie� metode na wyj�cie
            //(Exit) i na pozostanie w kontakcie (Stay)
        }

        void Update()
        {
            //Funkcja wykonuj�ca si� raz na klatk�.
            // czas -= Time.delataTime
        }

        private void FixedUpdate()
        {
            //Po tym evencie wykonuj� si� wszystkie obliczenia fizyki
            //i inne update�y.Nie zale�y ona od liczby klatek.
            //Mo�e si� wykona� kilka razy w ci�gu jednej klatki,
            //gdy mamy niski framerate, albo ani razu w trakcie klatki,
            //gdy framerate jest wysoki. Gdy tworzymy system poruszania
            //postaci wewn�trz tej funkcji, nie trzeba wykorzystywa� funkcji
            //Time.delataTime, poniewa� FixedUpdate dzia�a na zegarze,
            //kt�ry nie jest zale�ny od liczby klatek.Wykonuje si� w sta�ych
            //odst�pach czasu. T� funkcj� powinni�my wykorzystywa�,
            //gdy chcemy przeprowadza� obliczenia zwi�zane z fizyk�.
        }



        private void LateUpdate()
        {
            //R�wnie� wykonuje si� raz na klatk� i robi to zaraz
            //po zako�czeniu funkcji Update. Gdy wykonuje si� LateUpdate,
            //mamy pewno��, �e wszystkie obliczenia wewn�trz Update zosta�y
            //wykonane. Praktyczne zastosowanie? Gdy robimy system �ledzenia
            //jakiej� postaci za pomoc� kamery, mo�emy ruch postaci wykona� w
            //funkcji Update, a pod��anie kamery wewn�trz LateUpdate.
            //Dzi�ki temu, kamera namierzaj�c pozycj� postaci, ma pewno��,
            //�e ta ju� zako�czy�a sw�j ruch.
        }

        private void OnBecameVisible()
        {
            //Wywo�ana gdy obiekt staje si� widoczny
            //w polu widzenia jakiej� kamery. (Dowolnej).
        }

        private void OnBecameInvisible()
        {
            //Wywo�ana gdy obiekt staje si� niewidoczny w polu widzenia
            //jakiej� kamery. (Dowolnej).
           
        }

        private void OnDrawGizmos()
        {
            //Wykorzystywana do ryzowania Gizm w widoku sceny, do wizualizacji.
            //Czyli wykorzystywane w procesie produkcyjnym, ale nie w finalnej grze.
        }

        private void OnDestroy()
        {
            
            //Funkcja wywo�ana po funkcji Update, dla ostatniej klatki istnienia
            //obiektu. Obiekt mo�e przesta� istnie� przez u�ycie funkcji Destroy,
            //albo przez zamkni�cie obecnie wy�wietlanej sceny.
            //Wykorzystywany jako destruktor obiektu.
            //Wywo�ywana po OnDisable
        }

        private void OnApplicationQuit()
        {
            //Funkcja wywo�ywana dla wszystkich obiekt�w,
            //zanim aplikacja zostanie zamkni�ta.
            //W edytorze odpowiada temu wyj�cie z trybu grania,
            //a w przypadku webplayera odpowiada za to moment zamkni�cia
            //okienka z gr�.
        }
    }

}

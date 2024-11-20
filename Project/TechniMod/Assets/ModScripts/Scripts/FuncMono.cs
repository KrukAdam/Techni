using UnityEngine;


namespace ModScripts
{
    public class FuncMono : MonoBehaviour
    {
        //Opis najwa¿niejszych metod w MonoBehaviour
        //Pe³ny opis: https://mwin.pl/poznac-funkcje-unity/

        public GameObject prefab1;
        public Move prefab2;

        private void Awake()
        {
            //Funkcja, która wykonuje siê jako pierwsze,
            //zaraz gdy obiekt zostanie utworzony w scenie.
            //Jednak wykonuje siê tylko, gdy obiekt jest aktywny.
            //Jeœli nie jest, to funkcja jest pierwsz¹, która siê wykona,
            //gdy zostanie aktywowany

            var obj1 = Instantiate(prefab1);
            obj1.transform.position = Vector3.zero;
            obj1.GetComponent<Move>().speed = 1;

            var obj2 = Instantiate(prefab2);
            obj2.speed = 1.0f;


        }

        void Start()
        {
            //Wykonuje siê przed aktualizacj¹ pierwszej klatki.
            //Jedyna uwaga: instancja obiektu musi byæ w³¹czona,
            //a skrypt aktywny. Gdy Awake traktujemy jako konstruktor,
            //to funkcje Start powinniœmy wykorzystaæ do utworzenia relacji
            //skryptu z pozosta³ymi.
        }

        private void OnEnable()
        {
            //Tutaj mo¿na siê domyœliæ, ¿e funkcja wykona siê,
            //gdy komponent zostanie aktywowany.
            //Funkcja wykona siê tylko dla komponentów aktywnych.
            //Wykonuje siê przed funkcja start i w przeciwieñstwie do niej,
            //wykonuje siê przy ka¿dej aktywacji komponentu.
        }

        private void OnDisable()
        {
            //Wywo³ane gdy obiekt posiadaj¹cy skrypt stanie
            //wy³¹czony (disabled) albo nieaktywny (inactive).
        }

        private void OnCollisionEnter(Collision collision)
        {

            //W przeciwieñstwie do OnTriggerEnter,
            //OnCollisionEnter przekazuje klasê Collision,
            //a nie Collider. Klasa Collision zawiera informacje
            //m.in. o punktach styku i prêdkoœci uderzenia.
            //Uwagi: Zdarzenia kolizji s¹ wysy³ane tylko wtedy,
            //gdy do jednego ze zderzaczy jest równie¿ do³¹czony
            //non-kinematic rigidbody. Zdarzenia kolizyjne bêd¹
            //wysy³ane do wy³¹czonych MonoBehaviours,
            //aby umo¿liwiæ w³¹czenie zachowañ w odpowiedzi na kolizje.
        }

        private void OnTriggerEnter(Collider other)
        {
        //OnTriggerEnter ma miejsce w przypadku funkcji FixUpdate,
        //gdy zderzaj¹ siê dwa obiekty GameObject.
        //Zaanga¿owane Collidery nie zawsze znajduj¹
        //siê w punkcie pierwszego kontaktu.

        //Uwaga: Oba obiekty GameObject musz¹ zawieraæ
        //komponent Collider.Jeden musi mieæ w³¹czony
        //Collider.isTrigger i zawieraæ Rigidbody.
        //Jeœli oba obiekty GameObject maj¹ w³¹czon¹ opcjê
        //Collider.isTrigger, nie dochodzi do kolizji.
        //To samo dotyczy sytuacji, gdy oba GameObjects
        //nie maj¹ komponentu Rigidbody.
        }

        private void OnTriggerExit(Collider other)
        {
            //OnTriiger czy OnCollision maj¹ równie¿ metode na wyjœcie
            //(Exit) i na pozostanie w kontakcie (Stay)
        }

        void Update()
        {
            //Funkcja wykonuj¹ca siê raz na klatkê.
            // czas -= Time.delataTime
        }

        private void FixedUpdate()
        {
            //Po tym evencie wykonuj¹ siê wszystkie obliczenia fizyki
            //i inne update’y.Nie zale¿y ona od liczby klatek.
            //Mo¿e siê wykonaæ kilka razy w ci¹gu jednej klatki,
            //gdy mamy niski framerate, albo ani razu w trakcie klatki,
            //gdy framerate jest wysoki. Gdy tworzymy system poruszania
            //postaci wewn¹trz tej funkcji, nie trzeba wykorzystywaæ funkcji
            //Time.delataTime, poniewa¿ FixedUpdate dzia³a na zegarze,
            //który nie jest zale¿ny od liczby klatek.Wykonuje siê w sta³ych
            //odstêpach czasu. T¹ funkcjê powinniœmy wykorzystywaæ,
            //gdy chcemy przeprowadzaæ obliczenia zwi¹zane z fizyk¹.
        }



        private void LateUpdate()
        {
            //Równie¿ wykonuje siê raz na klatkê i robi to zaraz
            //po zakoñczeniu funkcji Update. Gdy wykonuje siê LateUpdate,
            //mamy pewnoœæ, ¿e wszystkie obliczenia wewn¹trz Update zosta³y
            //wykonane. Praktyczne zastosowanie? Gdy robimy system œledzenia
            //jakiejœ postaci za pomoc¹ kamery, mo¿emy ruch postaci wykonaæ w
            //funkcji Update, a pod¹¿anie kamery wewn¹trz LateUpdate.
            //Dziêki temu, kamera namierzaj¹c pozycjê postaci, ma pewnoœæ,
            //¿e ta ju¿ zakoñczy³a swój ruch.
        }

        private void OnBecameVisible()
        {
            //Wywo³ana gdy obiekt staje siê widoczny
            //w polu widzenia jakiejœ kamery. (Dowolnej).
        }

        private void OnBecameInvisible()
        {
            //Wywo³ana gdy obiekt staje siê niewidoczny w polu widzenia
            //jakiejœ kamery. (Dowolnej).
           
        }

        private void OnDrawGizmos()
        {
            //Wykorzystywana do ryzowania Gizm w widoku sceny, do wizualizacji.
            //Czyli wykorzystywane w procesie produkcyjnym, ale nie w finalnej grze.
        }

        private void OnDestroy()
        {
            
            //Funkcja wywo³ana po funkcji Update, dla ostatniej klatki istnienia
            //obiektu. Obiekt mo¿e przestaæ istnieæ przez u¿ycie funkcji Destroy,
            //albo przez zamkniêcie obecnie wyœwietlanej sceny.
            //Wykorzystywany jako destruktor obiektu.
            //Wywo³ywana po OnDisable
        }

        private void OnApplicationQuit()
        {
            //Funkcja wywo³ywana dla wszystkich obiektów,
            //zanim aplikacja zostanie zamkniêta.
            //W edytorze odpowiada temu wyjœcie z trybu grania,
            //a w przypadku webplayera odpowiada za to moment zamkniêcia
            //okienka z gr¹.
        }
    }

}

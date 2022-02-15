namespace Singleton
{
    public class Singleton
    {
        public static Singleton Instancia = null;
        public string mensaje = " ";

        protected Singleton()
        {
            mensaje = "Vive para aprender y ciertamente aprenderas a vivir.\n \n Jhon C. Maxwell.";
        }

        public static Singleton Instance
        {
            get
            {
                if (Instancia == null)
                    Instancia = new Singleton();

                return Instancia;
            }
        }
    }
}
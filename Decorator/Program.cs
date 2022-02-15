namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Patron de diseño del decorador
            IYaroa yaroa = new Yaroa();
            IYaroa papasFritasdecorator = new PapasFritasDecorator(yaroa);
            IYaroa ketchupDecorator = new KetchupDecorator(papasFritasdecorator);
            IYaroa mayonesaDecorator = new MayonesaDecorator(ketchupDecorator);
            IYaroa quesoDerretidoDecorator = new QuesoDerretidoDecorator(mayonesaDecorator);
            IYaroa carneDecorator = new CarneDecorator(quesoDerretidoDecorator);
            MessageBox.Show(carneDecorator.GetYaroaType());
        }
    }

    // Interfaz base 
    interface IYaroa
    {
        string GetYaroaType();
    }

    // Implementacion concreta
    class Yaroa : IYaroa
    {
        public string GetYaroaType()
        {
            return "Nuestras yaroas contienen: \n";
        }
    }

    // Decorardor base
    class YaroaDecorator : IYaroa
    {
        private IYaroa _yaroa;

        public YaroaDecorator(IYaroa yaroa)
        {
            _yaroa = yaroa;
        }

        public virtual string GetYaroaType()
        {
            return _yaroa.GetYaroaType();
        }
    }

    // Decoradores concretos

    class PapasFritasDecorator : YaroaDecorator
    {
        public PapasFritasDecorator(IYaroa yaroa) : base(yaroa) { }

        public override string GetYaroaType()
        {
            string ingrediente = base.GetYaroaType();
            ingrediente += "\n- papas fritas";
            return ingrediente;
        }
    }

    class KetchupDecorator : YaroaDecorator 
    {
        public KetchupDecorator(IYaroa yaroa) : base(yaroa) { }

        public override string GetYaroaType()
        {
            string ingrediente = base.GetYaroaType();
            ingrediente += "\n- ketchup";
            return ingrediente;
        }
    }

    class MayonesaDecorator : YaroaDecorator
    {
        public MayonesaDecorator(IYaroa yaroa) : base(yaroa) { }

        public override string GetYaroaType()
        {
            string ingrediente = base.GetYaroaType();
            ingrediente += "\n- mayonesa";
            return ingrediente;
        }
    }
    class QuesoDerretidoDecorator : YaroaDecorator
    {
        public QuesoDerretidoDecorator(IYaroa yaroa) : base(yaroa) { }

        public override string GetYaroaType()
        {
            string ingrediente = base.GetYaroaType();
            ingrediente += "\n- queso derretido";
            return ingrediente;
        }
    }

    class CarneDecorator : YaroaDecorator
    {
        public CarneDecorator(IYaroa yaroa) : base(yaroa) { }

        public override string GetYaroaType()
        {
            string ingrediente = base.GetYaroaType();
            ingrediente += "\n- carne de res y pollo";
            return ingrediente;
        }
    }

}

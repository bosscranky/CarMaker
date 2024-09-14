namespace CarMaker
{
    public class BaseAutomobile<T, U> where T : BaseEngine
        where U : BaseTransmission
    {
        public U Transmission { get; }

        public T Engine { get; }

        public bool Running { get; private set; }

        public BaseAutomobile(U gearbox, T icu)
        {
            Transmission = gearbox;
            Engine = icu;
        }

        public decimal GoForward(decimal distance)
        {
            // turn on car
            StartCar();
            // put car in gear
            // position steering
            // move forward

            // just assume everything is OK
            return distance;
        }

        protected bool StartCar()
        {
            if (!Running)
            {
                Engine.Start();
                Running = true;
            }

            return Running;

        }
    }
}

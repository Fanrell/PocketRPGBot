namespace PocketRpgBotDsc.Memento
{
    class RandomIntModule
    {
        private int _randomValue;
        private int _amountOfDuplicate;
        public int RandomValue 
        { 
            get => _randomValue; 
            set
            {
                _randomValue = value;
            }
                
        }
        public int AmountOfDuplicate 
        { 
          get => _amountOfDuplicate;
          set
            {
                _amountOfDuplicate = value;
            }
        }
    }
}

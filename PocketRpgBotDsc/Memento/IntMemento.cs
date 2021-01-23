using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRpgBotDsc.Memento
{
    class IntMemento
    {
        private RandomIntModule _randomIntState = new RandomIntModule();
        public IntMemento()
        {
            _randomIntState.AmountOfDuplicate = 0;
            _randomIntState.RandomValue = 0;
        }

        public bool Update(int randomValue)
        {
            if (randomValue == _randomIntState.RandomValue)
                _randomIntState.AmountOfDuplicate++;
            else
            {
                _randomIntState.RandomValue = randomValue;
                _randomIntState.AmountOfDuplicate = 1;
            }
            return CheckStun();
        }

        public int RandomValue
        {
            get => _randomIntState.RandomValue;
        }

        private bool CheckStun()
        {
            return (_randomIntState.AmountOfDuplicate == 3);
        }
    }
}

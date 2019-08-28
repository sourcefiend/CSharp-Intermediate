using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class PersonTwo
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return this._birthdate;
        }
    }
}

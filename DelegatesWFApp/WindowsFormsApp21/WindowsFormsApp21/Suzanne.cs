using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21
{
    class Suzanne
    {
        public GetSecretIngredient mySecretIngredientMethod
        {
            get
            {
                return new GetSecretIngredient(SuzanneSecretIngredient);
            }
        }

        private string SuzanneSecretIngredient(int amount)
        {
            return amount.ToString() + " ounces of cloves";
        }
    }
}

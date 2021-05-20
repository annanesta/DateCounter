using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCounter
{
    class Presenter
    {
        private Model model;
        public Presenter(Model model) { this.model = model; }

        //"объединяет" данные и переводит их в модель для обработки
        //я бы ещё так сказала - приводит данные в соответствующий вид
        public Model Login(string date)
        {
            date = date.Trim();         // Trim() - Удаляет все начальные и конечные символы-разделители из текущего объекта System.String.
            this.model.Load(date);
            return this.model;
        }
    }
}

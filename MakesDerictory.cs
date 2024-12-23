using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_TOPClassWork
{
    public static class MakesDerictory
    {
        private static List<Make> makes;
        public static List<Make> GetMakes()
        {
            if (makes == null)
            {
                makes = new List<Make> 
                {
                    new Make{
                        Date=DateTime.Now,
                        Title="Дело 1",
                        Description="Какое-то описание задачи, которое может быть длинным и при необходимости текст должен переноситься на новую строку.",
                        Tasks = new List<Task>
                        {
                            new Task(){Title = "Подзадача 1"},
                            new Task(){Title = "Подзадача 2"},
                            new Task(){Title = "Подзадача 3"},
                            new Task(){Title = "Выполненная подзадача", Check=true, TaskBrush = Brushes.Gray}
                        }
                    },
                    new Make{
                        Date=DateTime.Now,
                        Title="Дело 2",
                        Description="Очень важное дело",
                        Tasks = new List<Task>
                        {
                            new Task(){Title = "Подзадача 1"},
                            new Task(){Title = "Подзадача 2"},
                            new Task(){Title = "Подзадача 3"},
                            new Task(){Title = "Выполненная подзадача", Check=true, TaskBrush = Brushes.Gray}
                        }
                    }
                };
            }
            return makes;
        }
    }
}

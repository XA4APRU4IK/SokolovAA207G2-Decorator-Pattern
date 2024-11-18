using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class EmailNotifier : INotifier
    {
        private List<string> _admins;
        public EmailNotifier(List<string> admins)
        {
            _admins = admins;
        }
        public void Send(string message)
        {
            foreach (var admin in _admins)
            {
                Console.WriteLine($"Отправка email уведомления для {admin}: {message}");
            }
        }
    }
}

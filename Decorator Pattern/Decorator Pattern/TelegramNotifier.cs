using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class TelegramNotifier : NotifierDecorator
    {
        private List<string> _telegramUsers;
        public TelegramNotifier(INotifier notifier, List<string> telegramUsers) : base(notifier)
        {
            _telegramUsers = telegramUsers;
        }
        public override void Send(string message)
        {
            base.Send(message);
            foreach (var user in _telegramUsers)
            {
                Console.WriteLine($"Отправка Telegram уведомления для {user}: {message}");
            }
        }
    }
}

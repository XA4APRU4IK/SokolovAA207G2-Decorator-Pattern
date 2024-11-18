using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class SmsNotifier : NotifierDecorator
    {
        private List<string> _phoneNumbers;
        public SmsNotifier(INotifier notifier, List<string> phoneNumbers) : base(notifier)
        {
            _phoneNumbers = phoneNumbers;
        }
        public override void Send(string message)
        {
            base.Send(message);
            foreach (var number in _phoneNumbers)
            {
                Console.WriteLine($"Отправка SMS уведомления на {number}: {message}");
            }
        }
    }
}

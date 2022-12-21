using System;

namespace лб8._1
{
    class Program
    {
        public abstract class Phone
        {
            public abstract void MakeOutgoingCall(string phoneNumber);
            public abstract void ReceiveIncomingCall(string phoneNumber);
        }

        public class DialPhone : Phone
        {
            public override void MakeOutgoingCall(string phoneNumber)
            {
                // Реалізація для здійснення вихідного дзвінка за допомогою телефонного номера
            }

            public override void ReceiveIncomingCall(string phoneNumber)
            {
                // Реалізація прийому вхідного дзвінка за допомогою телефонного номера
            }
        }

        public class ButtonPhone : Phone
        {
            public override void MakeOutgoingCall(string phoneNumber)
            {
                // Реалізація для здійснення вихідного дзвінка за допомогою кнопкового телефону
            }

            public override void ReceiveIncomingCall(string phoneNumber)
            {
                // Реалізація прийому вхідного дзвінка за допомогою кнопкового телефону
            }

            public void DisplayCallerId(string phoneNumber)
            {
                // Реалізація відображення номера телефону абонента на екрані
            }
        }

        public class MobilePhone : Phone
        {
            public override void MakeOutgoingCall(string phoneNumber)
            {
                // Реалізація для здійснення вихідного дзвінка за допомогою мобільного телефону
            }

            public override void ReceiveIncomingCall(string phoneNumber)
            {
                // Реалізація прийому вхідного дзвінка за допомогою мобільного телефону
            }

            public void SendSms(string phoneNumber, string message)
            {
                // Реалізація для відправки SMS за допомогою мобільного телефону
            }

            public void ReceiveSms(string phoneNumber, string message)
            {
                // Реалізація для отримання SMS на мобільний телефон
            }
        }

        public class SmartPhone : MobilePhone
        {
            public void CreatePhoto()
            {
                // Реалізація для створення фото за допомогою смартфона
            }

            public void CreateVideo()
            {
                // Реалізація для створення відео за допомогою смартфона
            }
        }
    }
}

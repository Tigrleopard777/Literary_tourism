/*
 * Messages class
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteraryTourism
{
    class Messages
    {
        public static void ErrorAuth()
        {
            MessageBox.Show("Неправильный логин или пароль!", "Ошибка авторизации!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorConnection()
        {
            MessageBox.Show("Запрос не может быть опроботан, попробуйте позже!", "Ошибка соедиинения!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorComments()
        {
            MessageBox.Show("Извините, комментарии временно недоступны, попробуйте позже!", "Ошибка соедиинения!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorMarks()
        {
            MessageBox.Show("Извините, оценивание временно недоступно, попробуйте позже!", "Ошибка соедиинения!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorPictures()
        {
            MessageBox.Show("Извините, изображения временно недоступны, попробуйте позже!", "Ошибка соедиинения!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorRoutes()
        {
            MessageBox.Show("Извините, маршруты временно недоступны, попробуйте позже!", "Ошибка соедиинения!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

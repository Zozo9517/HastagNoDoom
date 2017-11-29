
namespace HashtagNoDoom.GameWindow
{
    class MVVM : Binding
    {
        const int character = 50;

        int life, score;

        public Shapes player { get; private set; }



        public MVVM(int palyaW, int palyaH)
        {
            life = 3;
            score = 0;
            player = new Shapes(palyaW / 2 - character / 2, palyaH - character, character, character);

        }

    }
}
namespace Lesson27
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class ReferenceManager
        {
            public static GameManager _GM; // Передачи зависимости через статичный тип
            public static GameAudiomanager _gameAudioManager; // Передачи зависимости через статичный тип
        }

        public class GameManager : IAudio
        {

            protected IAudio _audio;
            protected IGameManager _GameManager;

            public void UpdateState()
            {
                _GameManager.OnEndUpdateState();
            }
        }

        public class GameAudiomanager: IGameManager
        {
            protected IGameManager _GameManager;
            protected GameManager _GM;

            public GameAudiomanager(IGameManager _GameManager, GameManager _GM) // Инъекция зависимости
            {
                _GM = _GM;
                _GameManager = _GameManager;
            }

            void UpdateState()
            {
                ReferenceManager._GM.UpdateState();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson27
{
    public interface IAudio // Передачи зависимости через интерфейс
    {
        void UpdateState()
        {
        }
    }

    public interface IGameManager
    {
        void OnEndUpdateState()
        {

        }
    }
}

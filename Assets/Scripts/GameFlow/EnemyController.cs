using System.Collections.Generic;
using Enemies.Abstract;
using Updates;

namespace GameFlow
{
    internal sealed class EnemyController : IInitializable, IUpdatable
    {
        private List<Enemy> _enemies;
        public void Init()
        {
            _enemies = new List<Enemy>();
        }

        public void Update(float deltaTime)
        {
            //TODO: сделать перемещение всех врагов
            for (var i = 0; i < _enemies.Count; i++)
            {
                // _enemies[i].Move();
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace heartattackgames.flyweigth
{
    public sealed class EnemyFactory
    {
        private readonly Dictionary<EnemyType, IEnemy> _enemies = new ();

        [CanBeNull]
        public IEnemy GetEnemy(EnemyType enemyType)
        {
            if (_enemies.ContainsKey(enemyType))
                return _enemies.Single(e => e.Key == enemyType).Value;


            switch (enemyType)
            {
                case EnemyType.Zombie:
                    _enemies[enemyType] = new EnemyZombie();
                    return _enemies.Single(e => e.Key == enemyType).Value;
                
                case EnemyType.Monster: 
                    _enemies[enemyType] = new EnemyMonster();
                    return _enemies.Single(e => e.Key == enemyType).Value;
            }

            return null;
        }
    }
}
using UnityEngine;

namespace heartattackgames.flyweigth
{
    public class GameController: MonoBehaviour
    {
        public void Start() => Initialize();

        private void Initialize()
        {
            var enemyFactory = new EnemyFactory();

            var zombie = enemyFactory.GetEnemy(EnemyType.Zombie);
            var monster = enemyFactory.GetEnemy(EnemyType.Monster);
            
            zombie.Spawn();
            monster.Spawn();
        }
    }
}
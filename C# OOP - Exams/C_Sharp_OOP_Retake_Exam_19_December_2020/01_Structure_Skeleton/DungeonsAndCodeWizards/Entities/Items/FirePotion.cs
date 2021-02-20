using System;

using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        private const int CURRENT_ITEM_WEIGHT = 5;
        private const int HEALTH_DECREASE_VALUE = 20;

        public FirePotion() : base(CURRENT_ITEM_WEIGHT)
        {

        }

        public override void AffectCharacter(Character character)
        {
            //if (!character.IsAlive)
            //{
            //    throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            //}

            character.Health -= HEALTH_DECREASE_VALUE;

            if (character.Health <= 0)
            {
                character.IsAlive = false;
            }
        }
    }
}

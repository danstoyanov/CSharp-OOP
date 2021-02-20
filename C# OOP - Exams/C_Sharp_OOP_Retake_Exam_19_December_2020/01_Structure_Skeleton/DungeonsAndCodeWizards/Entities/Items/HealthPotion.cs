using System;

using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class HealthPotion : Item
    {
        private const int CURRENT_ITEM_WEIGHT = 5;
        private const int HEALTH_INCREASE_VALUE = 20;

        public HealthPotion() : base(CURRENT_ITEM_WEIGHT)
        {

        }

        public override void AffectCharacter(Character character)
        {
         //   if (!character.IsAlive)
         //   {
         //       throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
         //   }

            character.Health += HEALTH_INCREASE_VALUE;
        }
    }
}

using System;
namespace Bees.Models
{
    public interface IBee
    {
        bool Dead { get; }
        float Health { get; }

        void Damage(int damagePercentage);

    }
}

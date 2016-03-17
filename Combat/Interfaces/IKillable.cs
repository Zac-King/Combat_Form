
namespace Combat.Interfaces
{
    public interface IKillable
    {
        bool Alive { get; set; }    // On set Alive = false -> Call OnDeath

        void OnDeath();             // What do we do when object dies
    }
}

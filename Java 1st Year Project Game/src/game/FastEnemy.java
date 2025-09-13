package game;
import city.cs.engine.*;
/**
 *  Faster version of existing monster
 */

public class FastEnemy extends Enemy
{
    public FastEnemy(World world)
    {
        super(world);
        this.startWalking(6); // Faster speed than normal enemy
    }
}

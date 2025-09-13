package game;
import city.cs.engine.*;

/**
 * The HealingPotion class represents a potion that restores the Hero's health.

 * When the Hero collides with it, their HP increases (up to a maximum limit).
 */
public class HealingPotion extends DynamicBody {
    private static final Shape potionShape = new CircleShape(0.5f);
    private static final BodyImage potionImage = new BodyImage("data/healingpotion.png", 1.5f);

    public HealingPotion(World world)
    {
        super(world, potionShape);
        addImage(potionImage);
    }
}
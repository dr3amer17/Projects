package game;
import city.cs.engine.*;

/**
 * The PotionPickupListener class handles collisions between the Hero and the HealingPotion.
 */
//public class PotionPickupListener implements CollisionListener {
//    private Hero hero;
//
//    public PotionPickupListener(Hero hero)
//    {
//        this.hero = hero;
//    }
//
//    @Override
//    public void collide(CollisionEvent e) {
//        if (e.getOtherBody() instanceof HealingPotion && hero.getHp() < 100  ) {
//            hero.increaseHp(30); // Restore 30 HP
//            e.getOtherBody().destroy(); // Remove potion after pickup
//            System.out.println("Hero picked up a healing potion! HP: " + hero.getHp());
//        }
//    }
//}
package game;

import javax.sound.sampled.*;
import java.io.File;
import java.io.IOException;

/**
 * The Music class handles playing background music in the game.
 */
public class Music {
    private Clip clip;

    public void playMusic(String filePath) {
        try {
            File musicPath = new File(filePath);
            if (musicPath.exists()) {
                AudioInputStream audioInput = AudioSystem.getAudioInputStream(musicPath);
                clip = AudioSystem.getClip();
                clip.open(audioInput);
                clip.loop(Clip.LOOP_CONTINUOUSLY); // music loops forever
                clip.start();
            } else {
                System.out.println("Cannot find music file!");
            }
        } catch (UnsupportedAudioFileException | IOException | LineUnavailableException e) {
            e.printStackTrace();
        }
    }
}

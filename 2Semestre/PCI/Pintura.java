import java.awt.*;
import java.awt.event.*;

import vec2.Vec2;

public class Aula2 extends Frame {

	public static void main(String[] args) {
		
		new Aula2();
		
	}
	public Aula2() {
		super("Bitmap");
		setSize(400,300);
		setVisible(true);
		
		addWindowListener(new WindowAdapter()
			{public void windowClosing(WindowEvent e)
				{dispose(); close();}
			}
		);
	}
	
	public boolean requestClose = true;
	
	public void close(){
		requestClose = true;
		System.exit(0);
	}
	
	public void paint(Graphics g) {
			g.setColor(Color.red);
			g.drawRect(50,50,200,200);
			g.setColor(Color.blue);
			g.drawRect(20,20,20,20);
	}
}

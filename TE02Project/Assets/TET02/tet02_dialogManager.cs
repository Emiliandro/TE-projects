using UnityEngine;
using UnityEngine.UI;
using Tracery; 

public class tet02_dialogManager : MonoBehaviour 
{
	
	public Text dialogo;
	public Text character;
	public Grammar falasDoCacador = new Grammar();
	public string _conteudo;

	void Start(){
		falasDoCacador.PushRules ("Fala", new string[] {"Tem #conteudo#!"});
		falasDoCacador.PushRules ("conteudo", new string[] { "uma espada", "um arco", "outro bau", "uma bebida" });
		_conteudo = falasDoCacador.Flatten ("#Fala#");
		print (_conteudo);
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			setFala (_conteudo, "hunter");
		}
	}

	public void setFala(string oque, string quem)
	{
		dialogo.text = oque;
		character.text = quem;
	}

}

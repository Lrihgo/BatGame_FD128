static var Count : int = 0;
var CollectSound : AudioClip;




			
function OnTriggerEnter (other:Collider) {		
		//if (other.CompareTag("Player"))
		//{	
		GetComponent.<AudioSource>().PlayOneShot(CollectSound);
		Destroy (gameObject);
		Count++;
		
	//}	
	
}







function Update () {
	
if (Count == 3) 
{
	Count = 0;
	Application.LoadLevel ("gamelevel02");
	
	
}	
	
}
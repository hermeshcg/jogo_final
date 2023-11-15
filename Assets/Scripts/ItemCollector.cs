using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
		int coins = 0;

		[SerializeField] TMP_Text coinsText;

		[SerializeField] AudioSource collectionSound;

		private void OnTriggerEnter(Collider other)
		{
				if (other.gameObject.CompareTag("Coin"))
				{
						Destroy(other.gameObject);
						coins++;
						coinsText.text = "Moedas: " + coins;
						collectionSound.Play();
				}
		}
}
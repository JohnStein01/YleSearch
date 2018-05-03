using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class Parse : MonoBehaviour {

	// Use this for initialization
	public class Meta
	{
		public string offset { get; set; }
		public string limit { get; set; }
		public string type { get; set; }
		public int count { get; set; }
		public int program { get; set; }
		public int clip { get; set; }
	}

	public class Description
	{
		public string fi { get; set; }
	}

	public class Video
	{
		public List<object> language { get; set; }
		public List<object> format { get; set; }
		public string type { get; set; }
	}

	public class Description2
	{
		public string fi { get; set; }
	}

	public class Title
	{
		public string fi { get; set; }
		public string sv { get; set; }
	}

	public class CoverImage
	{
		public string id { get; set; }
		public bool available { get; set; }
		public string type { get; set; }
		public int version { get; set; }
	}

	public class Image
	{
		public string id { get; set; }
		public bool available { get; set; }
		public string type { get; set; }
		public int version { get; set; }
	}

	public class Title2
	{
		public string fi { get; set; }
		public string sv { get; set; }
	}

	public class Broader
	{
		public string id { get; set; }
	}

	public class Subject
	{
		public string id { get; set; }
		public Title2 title { get; set; }
		public string inScheme { get; set; }
		public string type { get; set; }
		public Broader broader { get; set; }
		public string key { get; set; }
	}

	public class PartOfSeries
	{
		public Description2 description { get; set; }
		public List<object> creator { get; set; }
		public List<string> alternativeId { get; set; }
		public string type { get; set; }
		public Title title { get; set; }
		public CoverImage coverImage { get; set; }
		public List<object> countryOfOrigin { get; set; }
		public string id { get; set; }
		public Image image { get; set; }
		public List<Subject> subject { get; set; }
	}

	public class Title3
	{
	}

	public class ContentRating
	{
		public Title3 title { get; set; }
		public List<object> reason { get; set; }
	}

	public class Title4
	{
		public string und { get; set; }
		public string fi { get; set; }
	}

	public class ItemTitle
	{
		public string fi { get; set; }
	}

	public class Image2
	{
		public string id { get; set; }
		public bool available { get; set; }
		public string type { get; set; }
		public int version { get; set; }
	}

	public class Audio
	{
		public List<string> language { get; set; }
		public List<object> format { get; set; }
		public string type { get; set; }
	}

	public class OriginalTitle
	{
	}

	public class Tags
	{
		public bool catalog { get; set; }
	}

	public class Service
	{
		public string id { get; set; }
	}

	public class Publisher
	{
		public string id { get; set; }
	}

	public class ContentProtection
	{
		public string id { get; set; }
		public string type { get; set; }
	}

	public class Media
	{
		public string id { get; set; }
		public string duration { get; set; }
		public List<ContentProtection> contentProtection { get; set; }
		public bool available { get; set; }
		public string type { get; set; }
		public bool downloadable { get; set; }
		public int version { get; set; }
	}

	public class PublicationEvent
	{
		public Tags tags { get; set; }
		public Service service { get; set; }
	//	public DateTime startTime { get; set; }
		public string temporalStatus { get; set; }
	//	public DateTime endTime { get; set; }
		public string type { get; set; }
		public string duration { get; set; }
		public string region { get; set; }
		public string id { get; set; }
		public int version { get; set; }
		public List<Publisher> publisher { get; set; }
		public Media media { get; set; }
	}

	public class Title5
	{
		public string fi { get; set; }
		public string en { get; set; }
		public string sv { get; set; }
	}

	public class Notation
	{
		public string value { get; set; }
		public string valueType { get; set; }
	}

	public class Broader2
	{
		public string id { get; set; }
	}

	public class Subject2
	{
		public string id { get; set; }
		public Title5 title { get; set; }
		public string inScheme { get; set; }
		public string type { get; set; }
		public List<Notation> notation { get; set; }
		public Broader2 broader { get; set; }
		public string key { get; set; }
	}

	public class Datum
	{
		public Description description { get; set; }
		public Video video { get; set; }
		public string typeMedia { get; set; }
		public List<object> creator { get; set; }
		public PartOfSeries partOfSeries { get; set; }
	//	public DateTime indexDataModified { get; set; }
		public string type { get; set; }
		public string duration { get; set; }
		public ContentRating contentRating { get; set; }
		public Title4 title { get; set; }
		public ItemTitle itemTitle { get; set; }
		public List<object> countryOfOrigin { get; set; }
		public string id { get; set; }
		public string typeCreative { get; set; }
		public Image2 image { get; set; }
		public List<Audio> audio { get; set; }
		public OriginalTitle originalTitle { get; set; }
		public List<PublicationEvent> publicationEvent { get; set; }
		public string collection { get; set; }
		public List<Subject2> subject { get; set; }
		public List<object> subtitling { get; set; }
	}

	public class RootObject
	{
		public string apiVersion { get; set; }
		public Meta meta { get; set; }
		public List<Datum> data { get; set; }
	}

	public static Parse CreateFromJSON(string jsonString)
	{

		return JsonUtility.FromJson<Parse>(jsonString);
	}
}

// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 

    using NUnit.Framework;
    using System;

    [TestFixture]
	public class StageTests
    {
		private Stage stage;

		[SetUp]
		public void SetUp()
        {
			stage = new Stage();
        }

		[Test]
	    public void IsValidateNullPerform_ThrowException_WhenPerformIsNull()
	    {
			Performer perform = null;
			Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(perform));
		}
		[Test]
		public void AddPerformer_ThrowException_WhenPerformerAgeIsLessThan18()
        {
			Performer performer = new Performer("Velik", "Charov", 17);

			Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }
		[Test]
		public void AddPerformer_AddCorectly()
        {
			Performer performer = new Performer("Velik", "Charov", 21);
			stage.AddPerformer(performer);

			int expected = 1;

			Assert.AreEqual(stage.Performers.Count, expected);
		}

		[Test]
		public void AddSong_ThrowException_WhenSongIsNull()
        {
			Song song = null;

			Assert.Throws<ArgumentNullException>(()=> stage.AddSong(song));
        }
		[Test]
		public void AddSong_ThrowException_WhenSongIsUnderOneMinute()
        {
			TimeSpan duration = new TimeSpan(0);
			Song song = new Song("Pesho", duration);

			Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }
		[Test]
		public void AddSongToPerfrom_ThrowException()
        {
			TimeSpan duration = new TimeSpan(0,2,45);
			Song song = new Song("Pesho", duration);
			stage.AddSong(song);
			Performer performer = new Performer("Velik", "Charov", 21);
			stage.AddPerformer(performer);

			Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("P", "Velik"));
		}
		[Test]
		public void AddSongToPerfrom_ThrowException2()
		{
			TimeSpan duration = new TimeSpan(0, 2, 45);
			Song song = new Song("Pesho", duration);
			stage.AddSong(song);
			Performer performer = new Performer("Velik", "Charov", 21);
			stage.AddPerformer(performer);

			Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Pesho", "Vel"));
		}
		[Test]
		public void AddToPerform_ShoudReturnCorectly()
        {
			TimeSpan duration = new TimeSpan(0, 2, 45);
			Song song = new Song("Pesho", duration);
			stage.AddSong(song);
			Performer performer = new Performer("Velik", "Charov", 21);
			stage.AddPerformer(performer);

			string expected = $"{song} will be performed by {performer.FullName}";

			string result = stage.AddSongToPerformer("Pesho", "Velik Charov");

			Assert.That(result, Is.EquivalentTo(expected));
		}
		[Test]
		public void Corectly()
        {
			TimeSpan duration = new TimeSpan(0, 2, 45);
			Song song = new Song("Pesho", duration);
			stage.AddSong(song);
			Performer performer = new Performer("Velik", "Charov", 21);
			stage.AddPerformer(performer);

			stage.AddSongToPerformer("Pesho", "Velik Charov");

			string expected = $"1 performers played 1 songs";

			string result = stage.Play();

			Assert.That(result, Is.EquivalentTo(expected));
		}
	}

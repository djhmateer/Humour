USE [britishADg6NEJHI]
GO
/****** Object:  Table [dbo].[Stories]    Script Date: 02/03/2014 18:25:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stories](
	[StoryID] [int] IDENTITY(1,1) NOT NULL,
	[StoryTypeID] [int] NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Content] [nvarchar](2048) NULL,
	[VideoURL] [nvarchar](max) NULL,
	[ImageURL] [nvarchar](max) NULL,
	[AddedDate] [datetime] NOT NULL,
	[Rating] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Stories] PRIMARY KEY CLUSTERED 
(
	[StoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[StoryTypes]    Script Date: 02/03/2014 18:25:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StoryTypes](
	[StoryTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.StoryTypes] PRIMARY KEY CLUSTERED 
(
	[StoryTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET IDENTITY_INSERT [dbo].[Stories] ON 

GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1, 1, N'Banana', N'Q: Why did the banana go to the doctors? A: He wasn''t peeling very well', NULL, NULL, CAST(0x0000A2AF00000000 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (2, 2, N'Glasgow Pizza Shop', NULL, N'//www.youtube.com/embed/y0TxfwB3BWQ?rel=0', NULL, CAST(0x0000A2AF00A1E899 AS DateTime), 2)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (7, 1, N'Fish', N'Q: What do you call a Fish with no eye?
A: Fsh', NULL, NULL, CAST(0x0000A2AE012A05E4 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (8, 1, N'Spade', N'Q: What do you call a man with a spade in his head?  A: Dug', NULL, NULL, CAST(0x0000A2AE012A3897 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (9, 1, N'Russle', N'Q: What do you call a man in a bush  A: Russle', NULL, NULL, CAST(0x0000A2AE012A703E AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (10, 1, N'Lily', N'Q: What do you call a girl with a frog on her head?  A: Lily', NULL, NULL, CAST(0x0000A2AE012A9211 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (11, 1, N'Brake fluid', N'My friend is addicted to drinking brake fluid, but he can stop at any time.', NULL, NULL, CAST(0x0000A2AE012AD999 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (12, 1, N'Demotivate - ship', NULL, NULL, N'http://demotivators.despair.com/demotivational/mistakesdemotivator.jpg', CAST(0x0000A2AE012B5940 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (19, 1, N'Holy Water', N'Q: How do you make holy water?  A: Boil the hell out of it', NULL, NULL, CAST(0x0000A2B200000000 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (20, 1, N'Copper', N'Q: What is Copper Nitrate?
A: Overtime pay for police officers', NULL, NULL, CAST(0x0000A2B2015B0C5A AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (21, 1, N'Ties', N'What kind of ties do pigs wear?  A Pig-sty', NULL, NULL, CAST(0x0000A2B2015C9D9A AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (22, 1, N'Cell', N'What do prisoners use to call each other?
Cell phones', NULL, NULL, CAST(0x0000A2B2015CC7EC AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (23, 1, N'Stick', N'What''s brown and sticky?
A stick', NULL, NULL, CAST(0x0000A2B2015D40EF AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (24, 1, N'Circle', N'Whats round and violent?  A vicious circle', NULL, NULL, CAST(0x0000A2B2015D5B65 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (27, 1, N'Fenton', NULL, N'//www.youtube.com/embed/3GRSbr0EYYU?rel=0', NULL, CAST(0x0000A2B40100E9F4 AS DateTime), 2)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (28, 1, N'poster', NULL, NULL, N'http://demotivators.despair.com/demotivational/revelationdemotivator.jpg', CAST(0x0000A2B40168BD5B AS DateTime), 3)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (29, 1, N'bee', N'Q:Why do bees hum? A: Because they don''t know the words!  ', NULL, NULL, CAST(0x0000A2B40169021C AS DateTime), 5)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (30, 1, N'baby Bee', N'Q: What is a baby bee?  Q: A little humbug', NULL, NULL, CAST(0x0000A2B4016936AE AS DateTime), 4)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (31, 1, N'cock a poodle', N'Q: What do you get if you cross a Cocker Spaniel with a Poodle and a Rooster?  A: Cock-a-Poodle-Doo!', NULL, NULL, CAST(0x0000A2B4016A88CA AS DateTime), 4)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (32, 1, N'misses the kisses', N'Q: What is the difference between a married man and a bachelor? A: One kissed the missus and the other misses the kisses', NULL, NULL, CAST(0x0000A2B4016C1230 AS DateTime), 4)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (33, 1, N'Bwenda', N'Q: What do you call a Chinese woman with a food processor on her head?  A: Brenda', NULL, NULL, CAST(0x0000A2B4016CAA88 AS DateTime), 4)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (34, 1, N'Neil', N'What do you call a man with no legs?  Neil', NULL, NULL, CAST(0x0000A2B4016CC556 AS DateTime), 5)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (35, 1, N'mac', N'What do you call a man who wears a coat? Mac

', NULL, NULL, CAST(0x0000A2B4016CFED0 AS DateTime), 3)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (36, 1, N'russian', N'What was the name of the russian pepsi delivery man?  I-drop-a-lot-of-popoff', NULL, NULL, CAST(0x0000A2B4016D2413 AS DateTime), 5)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (37, 1, N'eileen', N'What do you call a woman with 1 leg?  Eileen

What do you call a Chinese lady with 1 leg?  Irene!', NULL, NULL, CAST(0x0000A2B4016D6A72 AS DateTime), 5)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (38, 1, N'camo', N'I went to buy some camouflage trousers the other day but I couldn''t find any ', NULL, NULL, CAST(0x0000A2B5015E3F7F AS DateTime), 5)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (39, 1, N'jump-lead', N'A jump-lead walks into a bar.
The barman says "I''ll serve you, but don''t start anything."', NULL, NULL, CAST(0x0000A2B5015EB5CA AS DateTime), 6)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (40, 1, N'aerials', N'Two aerials meet on a roof, fall in love get married.
The ceremony wasn''t much but the reception was brilliant.
', NULL, NULL, CAST(0x0000A2B5015F00FF AS DateTime), 6)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (41, 1, N'strawberry', N'Man with a strawberry stuck up his bum goes to the doc.
Doc says "I''ll give you some cream to put on it."', NULL, NULL, CAST(0x0000A2B5015F3146 AS DateTime), 6)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (42, 1, N'hydrogen', N'Two hydrogen atoms walk into a bar.
One says, "I''ve lost my electron."
The other says, "Are you sure?"
The first replies, "Yes, I''m positive..."
', NULL, NULL, CAST(0x0000A2B5015F6E05 AS DateTime), 6)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (43, 1, N'murray', N'grasshopper walks into a bar
bartender says "we have a drink named after you."
grasshopper says "really? you have a drink named Murray?"', NULL, NULL, CAST(0x0000A2B5015FDEE2 AS DateTime), 6)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (44, 1, N'geek fun', NULL, NULL, N'http://geekfun.pl/pm_build_swing.gif', CAST(0x0000A2B50161BC58 AS DateTime), 7)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (45, 1, N'wtf', NULL, NULL, N'http://blog.pengoworks.com/enclosures/wtfm_cf7237e5-a580-4e22-a42a-f8597dd6c60b.jpg', CAST(0x0000A2B501624108 AS DateTime), 9)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (46, 1, N'One eyed dinosaur', N'What do you call a one eyed dinosaur?  Doyathinkysaurus', NULL, NULL, CAST(0x0000A2BB00000000 AS DateTime), 11)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (47, 1, N'Rex', N'What do you call a one eyed dinosaur''s dog? Doyathinkysaurus-rex', NULL, NULL, CAST(0x0000A2BB00000000 AS DateTime), 10)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (48, 1, N'Parrot', N'A man received a parrot for his birthday. The parrot was fully grown, with a bad attitude and worse vocabulary. Every other word was an expletive. Those that weren''t expletives were, to say the least, rude.The man tried hard to change the bird''s attitude and was constantly saying polite words, playing soft music, anything he could think of to try and set a good example. Nothing worked. He yelled at the bird and the bird yelled back.He shook the bird and the bird just got more angry and more rude. Finally, in a moment of desperation, the man put the parrot in the freezer. For a few moments he heard the bird squawk and kick and scream. Then suddenly there was quiet. Not a sound for half a minute. The man was frightened that he might have hurt the bird and quickly opened the freezer door. The parrot calmly stepped out onto the man''sextended arm and said, "I believe I may have offended you with my rude language and actions. I will endeavor at once to correct my behavior. I really am truly sorry and beg your forgiveness." The man was astonished at the bird''s change in attitude and was about to ask what had made such a dramatic change when the parrot continued,"May I ask what the chicken did?"', NULL, NULL, CAST(0x0000A2BB00000000 AS DateTime), 1)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (49, 1, N'Phil', N'What''s the name of the Scottish dentist?  Phil McAvity', NULL, NULL, CAST(0x0000A2BD007745C8 AS DateTime), 11)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (50, 1, N'boomerang', N'Have you heard the joke about the boomerang?  It''ll come back to you..', NULL, NULL, CAST(0x0000A2BE00FC4CA3 AS DateTime), 13)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1046, 1, N'Wonkey', N'What do you call a donkey with three legs?  A wonkey.  And where does it live?  An un-stable', NULL, NULL, CAST(0x0000A2C100000000 AS DateTime), 14)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1047, 1, N'Skydive', N'Why don''t blind people like to skydive?  Because it scares the dog.', NULL, NULL, CAST(0x0000A2C10167F11A AS DateTime), 12)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1048, 1, N'anarchy', N'Why do anarchists drink herbal tea?  Because proper-tea is theft', NULL, NULL, CAST(0x0000A2C4012DDB95 AS DateTime), 15)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1049, 1, N'dog', N'A blind man goes into a supermarket, picks his dog up, and swings it around his head.  A passer by exclaims "What are you doing"?????  The blind man says: Just looking around...', NULL, NULL, CAST(0x0000A2C6008CCD23 AS DateTime), 13)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1050, 1, N'Optimist', N'To the optimist, the glass is half-full. To the pessimist, the glass is
half-empty. To the engineer, the glass is twice as big as it needs to be.', NULL, NULL, CAST(0x0000A2CA00A1F52B AS DateTime), 16)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1051, 1, N'Engineers', N'A priest, a doctor, and an engineer were waiting one morning for a
particularly slow group of golfers.

The engineer fumed, "What''s with those guys? We must have been waiting for
fifteen minutes!"

The doctor chimed in, "I don''t know, but I''ve never seen  such inept golf!"

The priest said, "Here comes the greens-keeper. Let''s have a word with him."
He said, "Hello George, What''s wrong with that group ahead of us? They''re
rather slow, aren''t they?"

The greens-keeper replied, "Oh,  yes. That''s a group of blind firemen. They
lost their sight saving our clubhouse from a fire last year, so we always
let them play for free anytime!"

The group fell silent for a moment. The priest said, "That''s so sad. I think
I will say a special prayer for them tonight."

The doctor said, "Good idea. I''m going to contact my ophthalmologist
colleague and see if here''s anything she can do for them."

The engineer said, "Why can''t they play at night?"
', NULL, NULL, CAST(0x0000A2CA00A22A32 AS DateTime), 14)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1052, 1, N'arts', N'The graduate with a science degree asks, "Why does it work?"

The graduate with an engineering degree asks, "How does it work?"

The graduate with an accounting degree asks, "How much will it cost?"

The graduate with an arts degree asks, "Do you want fries with that?"
', NULL, NULL, CAST(0x0000A2CA00A24DE0 AS DateTime), 6)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (1053, 1, N'engineer features', N'Normal people believe that if it ain''t broke, don''t fix it. Engineers
believe that if it ain''t broke, it doesn''t have enough features yet.
', NULL, NULL, CAST(0x0000A2CA00A270D7 AS DateTime), 18)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (2050, 1, N'Wooly', N'What do you get if you cross a kangaroo with a sheep?  A woolly jumper', NULL, NULL, CAST(0x0000A2D50078BBCD AS DateTime), 14)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (2051, 1, N'Boomerang', N'What do you call a boomerang that doesn''t work?  A stick', NULL, NULL, CAST(0x0000A2D50079038E AS DateTime), 19)
GO
INSERT [dbo].[Stories] ([StoryID], [StoryTypeID], [Title], [Content], [VideoURL], [ImageURL], [AddedDate], [Rating]) VALUES (3050, 1, N'Yellow and dangerous', N'What''s yellow and very, very dangerous?  Shark Infested custard', NULL, NULL, CAST(0x0000A2D7007BA482 AS DateTime), 20)
GO
SET IDENTITY_INSERT [dbo].[Stories] OFF
GO
SET IDENTITY_INSERT [dbo].[StoryTypes] ON 

GO
INSERT [dbo].[StoryTypes] ([StoryTypeID], [Name]) VALUES (1, N'Joke')
GO
INSERT [dbo].[StoryTypes] ([StoryTypeID], [Name]) VALUES (2, N'Video')
GO
INSERT [dbo].[StoryTypes] ([StoryTypeID], [Name]) VALUES (3, N'Quote')
GO
INSERT [dbo].[StoryTypes] ([StoryTypeID], [Name]) VALUES (4, N'Picture')
GO
INSERT [dbo].[StoryTypes] ([StoryTypeID], [Name]) VALUES (5, N'AnimatedGIF')
GO
SET IDENTITY_INSERT [dbo].[StoryTypes] OFF
GO
ALTER TABLE [dbo].[Stories]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Stories_dbo.StoryTypes_StoryTypeID] FOREIGN KEY([StoryTypeID])
REFERENCES [dbo].[StoryTypes] ([StoryTypeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Stories] CHECK CONSTRAINT [FK_dbo.Stories_dbo.StoryTypes_StoryTypeID]
GO

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.film._test
{
	[TestClass]
	public class Db
	{
		[TestMethod]
		public void TestMethod1()
		{

			var s = @"
			
			1.The Shawshank Redemption (1994)9.6IMDb9.3
2.The Godfather (1972)9.2IMDb9.2
3.The Godfather: Part II (1974)9.1IMDb9.1
4.The Dark Knight (2008)8.9IMDb9.0
5.Pulp Fiction (1994)8.7IMDb9.0
6.The Good, the Bad and the Ugly (1966) ""Il buono, il brutto, il cattivo."" (original title)9.1IMDb9.0
7.Schindler's List (1993)9.3IMDb8.9
8.Fight Club (1999)9.0IMDb8.9
9.The Lord of the Rings: The Return of the King (2003)9.0IMDb8.9
10.12 Angry Men (1957)9.3IMDb8.9
11.Interstellar (2014)9.2IMDb8.9
12.Forrest Gump (1994)9.4IMDb8.8
13.Inception (2010)9.2IMDb8.8
14.One Flew Over the Cuckoo's Nest (1975)9.0IMDb8.8
15.The Lord of the Rings: The Two Towers (2002)8.9IMDb8.8
16.The Lord of the Rings: The Fellowship of the Ring (2001)8.9IMDb8.8
17.Star Wars: Episode V - The Empire Strikes Back (1980)IMDb8.8
18.Se7en (1995)8.7IMDb8.7
19.The Matrix (1999)8.7IMDb8.7
20.City of God (2002) ""Cidade de Deus"" (original title)8.9IMDb8.7
21.Seven Samurai (1954) ""Shichinin no samurai"" (original title)9.1IMDb8.7
22.The Usual Suspects (1995)8.6IMDb8.7
23.Goodfellas (1990)IMDb8.7
24.Star Wars (1977)IMDb8.7
25.It's a Wonderful Life (1946)IMDb8.7
26.Once Upon a Time in the West (1968) ""C'era una volta il West"" (original title)IMDb8.7
27.Léon (1994)9.4IMDb8.6
28.La vita è bella (1997)9.4IMDb8.6
29.Sen to Chihiro no Kamikakushi (2001)9.1IMDb8.6
30.The Intouchables (2011) ""Intouchables"" (original title)9.1IMDb8.6
31.The Silence of the Lambs (1991)8.7IMDb8.6
32.Saving Private Ryan (1998)8.8IMDb8.6
33.Modern Times (1936)9.1IMDb8.6
34.Casablanca (1942)8.6IMDb8.6
35.Psycho (1960)8.8IMDb8.6
36.City Lights (1931)9.2IMDb8.6
37.The Raiders of the Lost Ark (1981) ""Raiders of the Lost Ark"" (original title)IMDb8.6
38.American History X (1998)IMDb8.6
39.Rear Window (1954)IMDb8.6
40.Sunset Blvd. (1950)IMDb8.6
41.The Dark Knight Rises (2012)IMDb8.6
42.WALL·E (2008)9.3IMDb8.5
43.3 Idiots (2009)9.1IMDb8.5
44.Nuovo Cinema Paradiso (1988)9.1IMDb8.5
45.Amélie (2001) ""Le fabuleux destin d'Amélie Poulain"" (original title)8.8IMDb8.5
46.The Lives of Others (2006) ""Das Leben der Anderen"" (original title)9.1IMDb8.5
47.The Pianist (2002)9.0IMDb8.5
48.The Lion King (1994)8.8IMDb8.5
49.The Prestige (2006)8.8IMDb8.5
50.Hotaru no haka (1988)8.8IMDb8.5
51.Memento (2000)8.5IMDb8.5
52.The Green Mile (1999)8.7IMDb8.5
53.Jodaeiye Nader az Simin (2011)8.7IMDb8.5
54.Taare Zameen Par (2007)8.9IMDb8.5
55.Witness for the Prosecution (1957)9.5IMDb8.5
56.T2: Judgment Day (1991) ""Terminator 2: Judgment Day"" (original title)8.5IMDb8.5
57.American Beauty (1999)8.3IMDb8.5
58.Gladiator (2000)8.4IMDb8.5
59.Apocalypse Now (1979)IMDb8.5
60.Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb (1964)IMDb8.5
61.The Departed (2006)IMDb8.5
62.Back to the Future (1985)IMDb8.5
63.Alien (1979)IMDb8.5
64.The Great Dictator (1940)IMDb8.5
65.Django Unchained (2012)IMDb8.5
66.The Shining (1980)IMDb8.5
67.Paths of Glory (1957)IMDb8.5
68.North by Northwest (1959)IMDb8.5
69.Boyhood (I) (2014)IMDb8.5
70.M (1931)IMDb8.5
71.Das Boot (1981)IMDb8.5
72.Rang De Basanti (2006)IMDb8.5
73.Dil Chahta Hai (2001)IMDb8.5
74.Swades: We, the People (2004)IMDb8.5
75.Braveheart (1995)8.8IMDb8.4
76.Once Upon a Time in America (1984)9.0IMDb8.4
77.Mononoke-hime (1997)8.7IMDb8.4
78.Singin' in the Rain (1952)8.9IMDb8.4
79.Toy Story 3 (2010)8.8IMDb8.4
80.Requiem for a Dream (2000)8.8IMDb8.4
81.Rashômon (1950)8.7IMDb8.4
82.A Clockwork Orange (1971)8.4IMDb8.4
83.Eternal Sunshine of the Spotless Mind (2004)8.4IMDb8.4
84.Amadeus (1984)8.6IMDb8.4
85.Taxi Driver (1976)8.4IMDb8.4
86.Aliens (1986)IMDb8.4
87.Citizen Kane (1941)IMDb8.4
88.Vertigo (1958)IMDb8.4
89.Oldboy (2003) ""Oldeuboi"" (original title)IMDb8.4
90.Star Wars: Episode VI - The Return of the Jedi (1983) ""Star Wars: Episode VI - Return of the Jedi"" (original title)IMDb8.4
91.Double Indemnity (1944)IMDb8.4
92.Reservoir Dogs (1992)IMDb8.4
93.To Kill a Mockingbird (1962)IMDb8.4
94.Lawrence of Arabia (1962)IMDb8.4
95.Gone Girl (2014)IMDb8.4
96.Guardians of the Galaxy (2014)IMDb8.4
97.Full Metal Jacket (1987)IMDb8.4
98.Ladri di biciclette (1948)IMDb8.4
99.The Sting (1973)IMDb8.4
100.Monty Python and the Holy Grail (1975)IMDb8.4
101.All About Eve (1950)IMDb8.4
102.The Apartment (1960)IMDb8.4
103.The Kid (1921)IMDb8.4
104.The Treasure of the Sierra Madre (1948)IMDb8.4
105.The Third Man (1949)IMDb8.4
106.Yojimbo (1961) ""Yôjinbô"" (original title)IMDb8.4
107.Ikiru (1952)IMDb8.4
108.Tonari no Totoro (1988)9.1IMDb8.3
109.Up (2009)8.9IMDb8.3
110.Jagten (2012)9.0IMDb8.3
111.Snatch. (2000)8.5IMDb8.3
112.Inglourious Basterds (2009)8.3IMDb8.3
113.L.A. Confidential (1997)8.6IMDb8.3
114.For a Few Dollars More (1965) ""Per qualche dollaro in più"" (original title)IMDb8.3
115.Some Like It Hot (1959)IMDb8.3
116.2001: A Space Odyssey (1968)IMDb8.3
117.Indiana Jones and the Final Crusade (1989) ""Indiana Jones and the Last Crusade"" (original title)IMDb8.3
118.Batman Begins (2005)IMDb8.3
119.Toy Story (1995)IMDb8.3
120.Metropolis (1927)IMDb8.3
121.Raging Bull (1980)IMDb8.3
122.Scarface (1983)IMDb8.3
123.Chinatown (1974)IMDb8.3
124.Downfall (2004) ""Der Untergang"" (original title)IMDb8.3
125.Die Hard (1988)IMDb8.3
126.The Great Escape (1963)IMDb8.3
127.Mr. Smith Goes to Washington (1939)IMDb8.3
128.On the Waterfront (1954)IMDb8.3
129.Pan's Labyrinth (2006) ""El laberinto del fauno"" (original title)IMDb8.3
130.Heat (1995)IMDb8.3
131.The Bridge on the River Kwai (1957)IMDb8.3
132.The Wolf of Wall Street (2013)IMDb8.3
133.Det sjunde inseglet (1957)IMDb8.3
134.Smultronstället (1957)IMDb8.3
135.The Gold Rush (1925)IMDb8.3
136.Ran (1985)IMDb8.3
137.The General (1926)IMDb8.3
138.El secreto de sus ojos (2009)IMDb8.3
139.It Happened One Night (1934)IMDb8.3
140.Judgment at Nuremberg (1961)IMDb8.3
141.The Wages of Fear (1953) ""Le salaire de la peur"" (original title)IMDb8.3
142.Lagaan: Once Upon a Time in India (2001)IMDb8.3
143.Unforgiven (1992)8.4IMDb8.3
144.Hachi: A Dog's Tale (2009)9.2IMDb8.2
145.Gone with the Wind (1939)9.2IMDb8.2
146.Lock, Stock and Two Smoking Barrels (1998)9.0IMDb8.2
147.V for Vendetta (2005)8.8IMDb8.2
148.A Beautiful Mind (2001)8.9IMDb8.2
149.Hauru no ugoku shiro (2004)8.8IMDb8.2
150.Mary and Max (2009)8.9IMDb8.2
151.The Sixth Sense (1999)8.8IMDb8.2
152.Good Will Hunting (1997)8.7IMDb8.2
153.Kaze no tani no Naushika (1984)8.8IMDb8.2
154.How to Train Your Dragon (2010)8.7IMDb8.2
155.Trainspotting (1996)8.6IMDb8.2
156.Hotel Rwanda (2004)8.8IMDb8.2
157.Into the Wild (2007)8.7IMDb8.2
158.Warrior (2011)8.9IMDb8.2
159.The Elephant Man (1980)IMDb8.2
160.Blade Runner (1982)IMDb8.2
161.Gran Torino (2008)IMDb8.2
162.Casino (1995)IMDb8.2
163.The Big Lebowski (1998)IMDb8.2
164.Rebecca (1940)IMDb8.2
165.The Deer Hunter (1978)IMDb8.2
166.Cool Hand Luke (1967)IMDb8.2
167.Fargo (1996)IMDb8.2
168.Rush (I) (2013)IMDb8.2
169.The Maltese Falcon (1941)IMDb8.2
170.Dial M for Murder (1954)IMDb8.2
171.The Thing (1982)IMDb8.2
172.Finding Nemo (2003)IMDb8.2
173.No Country for Old Men (2007)IMDb8.2
174.Butch Cassidy and the Sundance Kid (1969)IMDb8.2
175.Kill Bill: Vol. 1 (2003)IMDb8.2
176.Platoon (1986)IMDb8.2
177.12 Years a Slave (2013)IMDb8.2
178.Life of Brian (1979)IMDb8.2
179.Incendies (2010)IMDb8.2
180.Network (1976)IMDb8.2
181.Touch of Evil (1958)IMDb8.2
182.Annie Hall (1977)IMDb8.2
183.Les diaboliques (1955)IMDb8.2
184.The Grand Budapest Hotel (2014)IMDb8.2
185.X-Men: Days of Future Past (2014)IMDb8.2
186.The Princess Bride (1987)IMDb8.2
187.Les quatre cents coups (1959)IMDb8.2
188.The Grapes of Wrath (1940)IMDb8.2
189.The Avengers (2012)IMDb8.2
190.The Best Years of Our Lives (1946)IMDb8.2
191.Persona (1966)IMDb8.2
192.8½ (1963)IMDb8.2
193.Stalker (1979)IMDb8.2
194.Fanny och Alexander (1982)IMDb8.2
195.The Battle of Algiers (1966) ""La battaglia di Algeri"" (original title)IMDb8.2
196.Underground (1995)IMDb8.2
197.Crna macka, beli macor (1998)IMDb8.2
198.Roman Holiday (1953)8.9IMDb8.1
199.Tenkû no shiro Rapyuta (1986)8.9IMDb8.1
200.Mou gaan dou (2002)8.8IMDb8.1
201.Before Sunrise (1995)8.7IMDb8.1
202.Before Sunset (2004)8.7IMDb8.1
203.Pirates of the Caribbean: The Curse of the Black Pearl (2003)8.5IMDb8.1
204.Shutter Island (2010)8.5IMDb8.1
205.The Bourne Ultimatum (2007)8.7IMDb8.1
206.Monsters, Inc. (2001)8.5IMDb8.1
207.Salinui chueok (2003)8.5IMDb8.1
208.Harry Potter and the Deathly Hallows: Part 2 (2011)8.6IMDb8.1
209.Fa yeung nin wa (2000)8.3IMDb8.1
210.The King's Speech (2010)8.3IMDb8.1
211.Stand by Me (1986)8.9IMDb8.1
212.Sin City (2005)IMDb8.1
213.There Will Be Blood (2007)IMDb8.1
214.Ben-Hur (1959)IMDb8.1
215.Amores perros (2000)IMDb8.1
216.The Wizard of Oz (1939)IMDb8.1
217.Million Dollar Baby (2004)IMDb8.1
218.In the Name of the Father (1993)IMDb8.1
219.Donnie Darko (2001)IMDb8.1
220.Gandhi (1982)IMDb8.1
221.Strangers on a Train (1951)IMDb8.1
222.Jaws (1975)IMDb8.1
223.High Noon (1952)IMDb8.1
224.Twelve Monkeys (1995)IMDb8.1
225.Notorious (1946)IMDb8.1
226.The Terminator (1984)IMDb8.1
227.Groundhog Day (1993)IMDb8.1
228.Yip Man (2008)IMDb8.1
229.The Night of the Hunter (1955)IMDb8.1
230.Rocky (1976)IMDb8.1
231.La Strada (1954) ""La strada"" (original title)IMDb8.1
232.Dog Day Afternoon (1975)IMDb8.1
233.La haine (1995)IMDb8.1
234.Who's Afraid of Virginia Woolf? (1966)IMDb8.1
235.Barry Lyndon (1975)IMDb8.1
236.The Big Sleep (1946)IMDb8.1
237.For a Fistful of Dollars (1964) ""Per un pugno di dollari"" (original title)IMDb8.1
238.The Help (2011)IMDb8.1
239.The Graduate (1967)IMDb8.1
240.The Hustler (1961)IMDb8.1
241.Her (2013)IMDb8.1
242.Festen (1998)IMDb8.1
243.Stalag 17 (1953)IMDb8.1
244.Beauty and the Beast (1991)IMDb8.1
245.Rope (1948)IMDb8.1
246.Papillon (1973)IMDb8.1
247.The Killing (1956)IMDb8.1
248.La Dolce Vita (1960) ""La dolce vita"" (original title)IMDb8.1
249.The Truman Show (1998)8.9IMDb8.0
250.Jurassic Park (1993)IMDb8.0


			
			";

			var ss = s.Split('\r', '\n');
			using (var db = nilnul.film.Db.CreateDbConnection())
			{
				foreach (var item in ss)
				{
					if (!string.IsNullOrWhiteSpace(item))
					{
						var film = new nilnul.film._db.Film();
						film.name = item;
						db.Film.Add(film);

			//			db.SaveChanges();
						var score = new nilnul.film._db.Score();
						score.Film1 = film;
						score.score1 = .9f;
						db.Score.Add(score);

					}


				}

			db.SaveChanges();

			}



		}
	}
}

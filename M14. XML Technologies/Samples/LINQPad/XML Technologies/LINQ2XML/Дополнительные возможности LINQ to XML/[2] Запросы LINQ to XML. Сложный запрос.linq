<Query Kind="Statements" />

//участники
XDocument users = XDocument.Parse(
		@"<users>
			<user_tuple>
			  <userid>U01</userid>
			  <name>Tom Jones</name>
			  <rating>B</rating>
			</user_tuple>
			<user_tuple>
			  <userid>U02</userid>
			  <name>Mary Doe</name>
			  <rating>A</rating>
			</user_tuple>
			<user_tuple>
			  <userid>U03</userid>
			  <name>Dee Linquent</name>
			  <rating>D</rating>
			</user_tuple>
			<user_tuple>
			  <userid>U04</userid>
			  <name>Roger Smith</name>
			  <rating>C</rating>
			</user_tuple>
			<user_tuple>
			  <userid>U05</userid>
			  <name>Jack Sprat</name>
			  <rating>B</rating>
			</user_tuple>
			<user_tuple>
			  <userid>U06</userid>
			  <name>Rip Van Winkle</name>
			  <rating>B</rating>
			</user_tuple>
		  </users>");
//лоты
XDocument items = XDocument.Parse(
		@"<items>
			<item_tuple>
			  <itemno>1001</itemno>
			  <description>Red Bicycle</description>
			  <offered_by>U01</offered_by>
			  <start_date>1999-01-05</start_date>
			  <end_date>1999-01-20</end_date>
			  <reserve_price>40</reserve_price>
			</item_tuple>
			<item_tuple>
			  <itemno>1002</itemno>
			  <description>Motorcycle</description>
			  <offered_by>U02</offered_by>
			  <start_date>1999-02-11</start_date>
			  <end_date>1999-03-15</end_date>
			  <reserve_price>500</reserve_price>
			</item_tuple>
			<item_tuple>
			  <itemno>1003</itemno>
			  <description>Old Bicycle</description>
			  <offered_by>U02</offered_by>
			  <start_date>1999-01-10</start_date>
			  <end_date>1999-02-20</end_date>
			  <reserve_price>25</reserve_price>
			</item_tuple>
			<item_tuple>
			  <itemno>1004</itemno>
			  <description>Tricycle</description>
			  <offered_by>U01</offered_by>
			  <start_date>1999-02-25</start_date>
			  <end_date>1999-03-08</end_date>
			  <reserve_price>15</reserve_price>
			</item_tuple>
			<item_tuple>
			  <itemno>1005</itemno>
			  <description>Tennis Racket</description>
			  <offered_by>U03</offered_by>
			  <start_date>1999-03-19</start_date>
			  <end_date>1999-04-30</end_date>
			  <reserve_price>20</reserve_price>
			</item_tuple>
			<item_tuple>
			  <itemno>1006</itemno>
			  <description>Helicopter</description>
			  <offered_by>U03</offered_by>
			  <start_date>1999-05-05</start_date>
			  <end_date>1999-05-25</end_date>
			  <reserve_price>50000</reserve_price>
			</item_tuple>
			<item_tuple>
			  <itemno>1007</itemno>
			  <description>Racing Bicycle</description>
			  <offered_by>U04</offered_by>
			  <start_date>1999-01-20</start_date>
			  <end_date>1999-02-20</end_date>
			  <reserve_price>200</reserve_price>
			</item_tuple>
			<item_tuple>
			  <itemno>1008</itemno>
			  <description>Broken Bicycle</description>
			  <offered_by>U01</offered_by>
			  <start_date>1999-02-05</start_date>
			  <end_date>1999-03-06</end_date>
			  <reserve_price>25</reserve_price>
			</item_tuple>
		  </items>");
//ставки
XDocument bids = XDocument.Parse(
		@"<bids>
			<bid_tuple>
			  <userid>U02</userid>
			  <itemno>1001</itemno>
			  <bid>35</bid>
			  <bid_date>1999-01-07</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U04</userid>
			  <itemno>1001</itemno>
			  <bid>40</bid>
			  <bid_date>1999-01-08</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U02</userid>
			  <itemno>1001</itemno>
			  <bid>45</bid>
			  <bid_date>1999-01-11</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U04</userid>
			  <itemno>1001</itemno>
			  <bid>50</bid>
			  <bid_date>1999-01-13</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U02</userid>
			  <itemno>1001</itemno>
			  <bid>55</bid>
			  <bid_date>1999-01-15</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U01</userid>
			  <itemno>1002</itemno>
			  <bid>400</bid>
			  <bid_date>1999-02-14</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U02</userid>
			  <itemno>1002</itemno>
			  <bid>600</bid>
			  <bid_date>1999-02-16</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U03</userid>
			  <itemno>1002</itemno>
			  <bid>800</bid>
			  <bid_date>1999-02-17</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U04</userid>
			  <itemno>1002</itemno>
			  <bid>1000</bid>
			  <bid_date>1999-02-25</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U02</userid>
			  <itemno>1002</itemno>
			  <bid>1200</bid>
			  <bid_date>1999-03-02</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U04</userid>
			  <itemno>1003</itemno>
			  <bid>15</bid>
			  <bid_date>1999-01-22</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U05</userid>
			  <itemno>1003</itemno>
			  <bid>20</bid>
			  <bid_date>1999-02-03</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U01</userid>
			  <itemno>1004</itemno>
			  <bid>40</bid>
			  <bid_date>1999-03-05</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U03</userid>
			  <itemno>1007</itemno>
			  <bid>175</bid>
			  <bid_date>1999-01-25</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U05</userid>
			  <itemno>1007</itemno>
			  <bid>200</bid>
			  <bid_date>1999-02-08</bid_date>
			</bid_tuple>
			<bid_tuple>
			  <userid>U04</userid>
			  <itemno>1007</itemno>
			  <bid>225</bid>
			  <bid_date>1999-02-12</bid_date>
			</bid_tuple>
		  </bids>");
		  
users.Dump("users");
items.Dump("items");
bids.Dump("bids");
//Запрос должен производить список всех цен, превышающих $50.
//В результатах должна присутствовать дата и цена, наряду с пользователем, 
//предложившим ее, а также наименование товара и его описание

var biddata = from b in bids.Descendants("bid_tuple")
					where ((double)b.Element("bid") > 50)
					join u in users.Descendants("user_tuple")
					on ((string)b.Element("userid")) equals
					  ((string)u.Element("userid"))
					join i in items.Descendants("item_tuple")
					on ((string)b.Element("itemno")) equals
					  ((string)i.Element("itemno"))
					select new
					{
					  Item = ((string)b.Element("itemno")),
					  Description = ((string)i.Element("description")),
					  User = ((string)u.Element("name")),
					  Date = ((string)b.Element("bid_date")),
					  Price = ((double)b.Element("bid"))
					};
					
biddata.Dump("===============================");
//три XML-документа были соединены в одном запросе. Мощь LINQ to XML!
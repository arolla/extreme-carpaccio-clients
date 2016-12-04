package xcarpaccio;

import java.util.List;

public class Quote {
	public String returnDate;
	public String cover;
	public String country;
	public List<String> options;
	public List<String> travellerAges;
	public String departureDate;

	@Override
	public String toString() {
		return "Quote{" +
				"returnDate='" + returnDate + '\'' +
				", cover='" + cover + '\'' +
				", country='" + country + '\'' +
				", options='" + options + '\'' +
				", travellersAge='" + travellerAges + '\'' +
				", departureDate='" + departureDate + '\'' +
				'}';
	}
}

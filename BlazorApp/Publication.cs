/* Class to contain all Publication information in one place */

public class Publication {
    // title, authors before me, authors after me, conference details, link
    public string title;
    public string authorsBefore;
    public string authorsAfter;
    public string conferenceDetails;
    public string link;

    public Publication(string title, string authorsBefore, string authorsAfter, string conferenceDetails, string link) {
        this.title = title;
        this.authorsBefore = authorsBefore;
        this.authorsAfter = authorsAfter;
        this.conferenceDetails = conferenceDetails;
        this.link = link;
    }
}
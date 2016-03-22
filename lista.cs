void lista (int iloscstron_min, string kategoria, string tematyka)
{
	return(db.Lista.Where(x => x.Pages == iloscstron_min && x.Category == kategoria && x.Subject == tematyka).ToList())
}
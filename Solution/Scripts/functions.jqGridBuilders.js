function numbersOnly(e) {
	var unicode = e.charCode ? e.charCode : e.keyCode

	if ((unicode >= 8 && unicode <= 9) || unicode == 44 || (unicode >= 37 && unicode <= 39))
	{ return true }
	else
		if (unicode < 48 || unicode > 57) //if not a number
		{ return false }  //disable key press
}
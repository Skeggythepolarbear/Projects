public static void Effects(Player player) {
	player.meleeCrit += 20;
	player.noKnockback = true;
}

public static void SetBonus(Player player) {
	player.setBonus = "Increased defense by 40";
	player.statDefense += 40;
    player.statAttack += 100;
    player.socialShadow = true
}
# Finite-Game-State-Pattern-Implementation
Daha önceden geliştirmiş olduğum MatchingGame prototipinin State Machine implementasyonu yapılmış bir kopyasını içeren repo'dur.<br>

NOT: Bu repo'daki proje daha önce geliştirilmiş olan MatchingGameViaCommandPattern isimli projenin güncellenmiş ve State Machine eklenmiş versiyonudur. Bu Readme'de açıklanmayan sınıfların açıklamasını aşağıdaki linkten bulabilirsiniz. Bu Readme'de sadece State Machine için eklenmiş yeni sınıflar açıklanmıştır. <br><br>

MatchingGameViaCommandPattern repo : https://github.com/Unitarian2/MatchingGameViaCommandPattern <br><br>

---GameState Classes---<br>
GameBaseState.cs => Oluşturulacak her state'in miras alacağı Base class. Kullanacağı GameStateManager her method'da parametre olarak verilerek kullanılır.<br>
GameBoardSetupState.cs => Concrete GameState sınıfı. Masanın kurulum aşamasında olduğu state'dir. Masa kurulumu yapılır.
GamePlayerTurnState.cs => Oyuncunun oynama sırasının geldiği state'dir. Oyuncu kontrolleri aktifleştirilir.
GameTransitionState.cs => Oyuncu swap command'ini verdikten sonra oyunun swap işlemi, başarılı eşleşmeleri patlatması ve yeni ikonlar spawn etmesi gibi işlemleri gerçekleştirdiği, oyuncunun kontrollerinin deaktif olduğu state'dir.




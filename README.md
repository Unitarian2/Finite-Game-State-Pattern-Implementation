# Finite-Game-State-Pattern-Implementation
Daha önceden geliştirmiş olduğum MatchingGame prototipinin State Machine implementasyonu yapılmış bir kopyasını içeren repo'dur.<br>

NOT: Bu repo'daki proje daha önce geliştirilmiş olan MatchingGameViaCommandPattern isimli projenin güncellenmiş ve State Machine eklenmiş versiyonudur. Bu Readme'de açıklanmayan sınıfların açıklamasını aşağıdaki linkten bulabilirsiniz. Bu Readme'de sadece State Machine için eklenmiş yeni sınıflar açıklanmıştır. <br><br>

MatchingGameViaCommandPattern repo : https://github.com/Unitarian2/MatchingGameViaCommandPattern <br><br>

---GameState Classes---<br>
<b>GameBaseState.cs =></b> Oluşturulacak her state'in miras alacağı Base class. Kullanacağı GameStateManager her method'da parametre olarak verilerek kullanılır.<br>
<b>GameBoardSetupState.cs =></b> Concrete GameState sınıfı. Masanın kurulum aşamasında olduğu state'dir. Masa kurulumu yapılır.<br>
<b>GamePlayerTurnState.cs =></b> Oyuncunun oynama sırasının geldiği state'dir. Oyuncu kontrolleri aktifleştirilir.<br>
<b>GameTransitionState.cs =></b> Oyuncu swap command'ini verdikten sonra oyunun swap işlemi, başarılı eşleşmeleri patlatması ve yeni ikonlar spawn etmesi gibi işlemleri gerçekleştirdiği, oyuncunun kontrollerinin deaktif olduğu state'dir.<br><br>

<b>GameManager.cs'daki değişimler</b><br>
- ValidationCompleted methodu eklendi. Bu method oyun TransitionState'deki tüm işlemleri gerçekleştirdikten sonra oyuncuya kontrollerini tekrar vermek adına oyun state'ini GamePlayerTurnState'e geçirir.<br>
- Start methodu içerisinde artık BoardSetupState'e geçiyoruz ve masanın kurulumu işlemini başlatıyoruz.<br>
- StartGameValidationProcess methodu artık her çağırıldığında ilk olarak GameTransitionState'e geçiyoruz ki oyuncu kontrolleri artık kapansın.<br>




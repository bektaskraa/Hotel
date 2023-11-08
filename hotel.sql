-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 08 Kas 2023, 18:39:05
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `hotel`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri`
--

CREATE TABLE `musteri` (
  `id` int(11) NOT NULL,
  `adi` varchar(50) NOT NULL,
  `tc` varchar(11) NOT NULL,
  `telefon` varchar(15) NOT NULL,
  `mail` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `musteri`
--

INSERT INTO `musteri` (`id`, `adi`, `tc`, `telefon`, `mail`) VALUES
(1, 'Mehmet Albayrak', '14234235645', '5424829073', 'test@gmail.com'),
(2, 'Kerem Erkan', '11234235645', '5424829073', 'kerm@gmail.com'),
(7, 'Bektaş Kara', '11705665708', '05424829073', 'bektaskara4@gmail.com'),
(8, 'Baha Kurt', '31981986274', '05424534356', 'bahakurt@gmail.com');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri_oda`
--

CREATE TABLE `musteri_oda` (
  `id` int(11) NOT NULL,
  `musteriId` int(11) NOT NULL,
  `odaId` int(11) NOT NULL,
  `geceSayisi` int(11) NOT NULL,
  `fiyat` double NOT NULL,
  `rezervasyonGunu` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `musteri_oda`
--

INSERT INTO `musteri_oda` (`id`, `musteriId`, `odaId`, `geceSayisi`, `fiyat`, `rezervasyonGunu`) VALUES
(1, 1, 1, 2, 240, '2023-10-21'),
(2, 2, 2, 4, 0, '2023-10-23'),
(9, 2, 3, 3, 0, '2023-10-27'),
(10, 7, 4, 2, 0, '2023-10-25'),
(20, 7, 1, 2, 0, '2023-10-26'),
(22, 7, 1, 2, 240, '2023-11-02'),
(23, 7, 1, 3, 360, '2023-11-04');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `oda`
--

CREATE TABLE `oda` (
  `id` int(11) NOT NULL,
  `numara` text NOT NULL,
  `tipId` int(11) NOT NULL,
  `durum` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `oda`
--

INSERT INTO `oda` (`id`, `numara`, `tipId`, `durum`) VALUES
(1, '001', 1, 0),
(2, '002', 1, 0),
(3, '101', 3, 0),
(4, '102', 2, 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `oda_tip`
--

CREATE TABLE `oda_tip` (
  `id` int(11) NOT NULL,
  `tipAdi` varchar(50) NOT NULL,
  `fiyat` double NOT NULL,
  `yatakSayisi` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `oda_tip`
--

INSERT INTO `oda_tip` (`id`, `tipAdi`, `fiyat`, `yatakSayisi`) VALUES
(1, '1 Kişilik Normal', 120, 1),
(2, '2 Kişilik Normal', 260, 2),
(3, '1 Kişilik Kral Dairesi', 4500, 1),
(4, '2 Kişlik Premium Daire', 12000, 2),
(5, 'test', 23.4, 5);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `musteri`
--
ALTER TABLE `musteri`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `musteri_oda`
--
ALTER TABLE `musteri_oda`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `oda`
--
ALTER TABLE `oda`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `oda_tip`
--
ALTER TABLE `oda_tip`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `musteri`
--
ALTER TABLE `musteri`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Tablo için AUTO_INCREMENT değeri `musteri_oda`
--
ALTER TABLE `musteri_oda`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Tablo için AUTO_INCREMENT değeri `oda`
--
ALTER TABLE `oda`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `oda_tip`
--
ALTER TABLE `oda_tip`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Nov 24, 2024 at 05:31 AM
-- Server version: 8.0.30
-- PHP Version: 8.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_inventaris`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteBarang` (IN `p_id_barang` INT)   BEGIN
    DELETE FROM barang WHERE id_barang = p_id_barang;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteInventaris` (IN `id_inventaris` INT)   BEGIN
    DELETE FROM inventaris WHERE id_inventaris = id_inventaris;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteLokasi` (IN `p_id_lokasi` INT)   BEGIN
    DELETE FROM lokasi WHERE id_lokasi = p_id_lokasi;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletePemeliharaan` (IN `p_id_pemeliharaan` INT)   BEGIN
    DELETE FROM pemeliharaan WHERE id_pemeliharaan = p_id_pemeliharaan;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletePeminjaman` (IN `p_id_peminjaman` INT)   BEGIN
    DELETE FROM peminjaman WHERE id_peminjaman = p_id_peminjaman;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteUser` (IN `p_id_user` INT)   BEGIN
    DELETE FROM `user` WHERE id_user = p_id_user;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertBarang` (IN `p_nama_barang` VARCHAR(255), IN `p_jumlah_barang` INT, IN `p_merk` VARCHAR(255), IN `p_id_lokasi` INT)   BEGIN
    INSERT INTO barang (nama_barang, jumlah_barang, merk, id_lokasi)
    VALUES (p_nama_barang, p_jumlah_barang, p_merk, p_id_lokasi);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertInventaris` (IN `keterangan_inventaris` VARCHAR(255), IN `kondisi_barang` VARCHAR(255), IN `id_barang` INT)   BEGIN
    INSERT INTO inventaris (keterangan_inventaris, kondisi_barang, id_barang)
    VALUES (keterangan_inventaris, kondisi_barang, id_barang);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertLokasi` (IN `p_nama_lokasi` VARCHAR(255), IN `p_ruang_penyimpanan` VARCHAR(255))   BEGIN
    INSERT INTO lokasi (nama_lokasi, ruang_penyimpanan)
    VALUES (p_nama_lokasi, p_ruang_penyimpanan);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertPemeliharaan` (IN `p_id_barang` INT, IN `p_jadwal_pemeliharaan` DATE, IN `p_perbaikan_barang` VARCHAR(255))   BEGIN
    INSERT INTO pemeliharaan (id_barang, jadwal_pemeliharaan, perbaikan_barang)
    VALUES (p_id_barang, p_jadwal_pemeliharaan, p_perbaikan_barang);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertPeminjaman` (IN `p_id_barang` INT, IN `p_keterangan_peminjaman` VARCHAR(255), IN `p_tgl_peminjaman` DATE, IN `p_tgl_pengembalian` DATE)   BEGIN
    INSERT INTO peminjaman (id_barang, keterangan_peminjaman, tgl_peminjaman, tgl_pengembalian)
    VALUES (p_id_barang, p_keterangan_peminjaman, p_tgl_peminjaman, p_tgl_pengembalian);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertUser` (IN `p_username` VARCHAR(255), IN `p_password` VARCHAR(255), IN `p_role` VARCHAR(255))   BEGIN
    INSERT INTO `user` (username, password, role) VALUES (p_username, p_password, p_role);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateBarang` (IN `p_id_barang` INT, IN `p_nama_barang` VARCHAR(255), IN `p_jumlah_barang` INT, IN `p_merk` VARCHAR(255), IN `p_id_lokasi` INT)   BEGIN
    UPDATE barang
    SET
        nama_barang = p_nama_barang,
        jumlah_barang = p_jumlah_barang,
        merk = p_merk,
        id_lokasi = p_id_lokasi
    WHERE id_barang = p_id_barang;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateInventaris` (IN `keterangan_inventaris` VARCHAR(255), IN `kondisi_barang` VARCHAR(255), IN `id_barang` INT)   BEGIN
    UPDATE inventaris
    SET keterangan_inventaris = keterangan_inventaris, kondisi_barang = kondisi_barang
    WHERE id_barang = id_barang;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateLokasi` (IN `p_id_lokasi` INT, IN `p_nama_lokasi` VARCHAR(255), IN `p_ruang_penyimpanan` VARCHAR(255))   BEGIN
    UPDATE lokasi
    SET
        nama_lokasi = p_nama_lokasi,
        ruang_penyimpanan = p_ruang_penyimpanan
    WHERE id_lokasi = p_id_lokasi;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePemeliharaan` (IN `p_id_pemeliharaan` INT, IN `p_id_barang` INT, IN `p_jadwal_pemeliharaan` DATE, IN `p_perbaikan_barang` VARCHAR(255))   BEGIN
    UPDATE pemeliharaan
    SET
        id_barang = p_id_barang,
        jadwal_pemeliharaan = p_jadwal_pemeliharaan,
        perbaikan_barang = p_perbaikan_barang
    WHERE id_pemeliharaan = p_id_pemeliharaan;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePeminjaman` (IN `p_id_peminjaman` INT, IN `p_id_barang` INT, IN `p_keterangan_peminjaman` VARCHAR(255), IN `p_tgl_peminjaman` DATE, IN `p_tgl_pengembalian` DATE)   BEGIN
    UPDATE peminjaman
    SET
        id_barang = p_id_barang,
        keterangan_peminjaman = p_keterangan_peminjaman,
        tgl_peminjaman = p_tgl_peminjaman,
        tgl_pengembalian = p_tgl_pengembalian
    WHERE id_peminjaman = p_id_peminjaman;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateUser` (IN `p_id_user` INT, IN `p_username` VARCHAR(255), IN `p_password` VARCHAR(255), IN `p_role` VARCHAR(255))   BEGIN
    UPDATE `user` SET username = p_username, password = p_password, role = p_role WHERE id_user = p_id_user;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `id_barang` int NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `jumlah_barang` int NOT NULL,
  `merk` varchar(100) DEFAULT NULL,
  `id_lokasi` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`id_barang`, `nama_barang`, `jumlah_barang`, `merk`, `id_lokasi`) VALUES
(1, 'Jangka Sorong', 12, 'Mitutoyo', 1),
(2, 'Monitor', 12, 'Samsung', 2),
(3, 'Keyboard', 12, 'Logitech', 3),
(4, 'PLC Omron', 12, 'Toshiba', 4);

--
-- Triggers `barang`
--
DELIMITER $$
CREATE TRIGGER `after_insert_barang` AFTER INSERT ON `barang` FOR EACH ROW BEGIN
    CALL CheckJumlahBarang(NEW.id_barang);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `inventaris`
--

CREATE TABLE `inventaris` (
  `id_inventaris` int NOT NULL,
  `keterangan_inventaris` text,
  `kondisi_barang` varchar(100) DEFAULT NULL,
  `id_barang` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `inventaris`
--

INSERT INTO `inventaris` (`id_inventaris`, `keterangan_inventaris`, `kondisi_barang`, `id_barang`) VALUES
(1, 'Diaz 1AEC4', 'Baik', 1),
(2, 'Bayu 1AEC4', 'Baik', 2),
(3, 'Mahendra 1AEC4', 'Baik', 3),
(4, 'Ihsan 1AEC4', 'Baik', 4);

-- --------------------------------------------------------

--
-- Table structure for table `lokasi`
--

CREATE TABLE `lokasi` (
  `id_lokasi` int NOT NULL,
  `nama_lokasi` varchar(100) DEFAULT NULL,
  `ruang_penyimpanan` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `lokasi`
--

INSERT INTO `lokasi` (`id_lokasi`, `nama_lokasi`, `ruang_penyimpanan`) VALUES
(1, 'Lantai 1 AE', 'Lab Elmek'),
(2, 'Lantai 4 AE', 'Lab Informatika 1'),
(3, 'Lantai 4 AE', 'Lab Informatika 2'),
(4, 'Lantai 4 AE', 'Lab PLC');

-- --------------------------------------------------------

--
-- Table structure for table `pemeliharaan`
--

CREATE TABLE `pemeliharaan` (
  `id_pemeliharaan` int NOT NULL,
  `jadwal_pemeliharaan` date DEFAULT NULL,
  `perbaikan_barang` varchar(100) DEFAULT NULL,
  `id_barang` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `pemeliharaan`
--

INSERT INTO `pemeliharaan` (`id_pemeliharaan`, `jadwal_pemeliharaan`, `perbaikan_barang`, `id_barang`) VALUES
(1, '2023-12-11', 'Perbaikan pada LCD Monitor', 2),
(2, '2023-12-15', 'Perbaikan pada kabel PLC', 4);

--
-- Triggers `pemeliharaan`
--
DELIMITER $$
CREATE TRIGGER `after_delete_pemeliharaan` AFTER DELETE ON `pemeliharaan` FOR EACH ROW BEGIN
    DECLARE barang_count INT;
    SELECT jumlah_barang INTO barang_count
    FROM barang
    WHERE id_barang = OLD.id_barang;
    UPDATE barang
    SET jumlah_barang = barang_count + 1
    WHERE id_barang = OLD.id_barang;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_insert_pemeliharaan` AFTER INSERT ON `pemeliharaan` FOR EACH ROW BEGIN
    DECLARE barang_count INT;
    SELECT jumlah_barang INTO barang_count
    FROM barang
    WHERE id_barang = NEW.id_barang;
    UPDATE barang
    SET jumlah_barang = barang_count - 1
    WHERE id_barang = NEW.id_barang;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `peminjaman`
--

CREATE TABLE `peminjaman` (
  `id_peminjaman` int NOT NULL,
  `keterangan_peminjaman` text,
  `tgl_peminjaman` date DEFAULT NULL,
  `tgl_pengembalian` date DEFAULT NULL,
  `id_barang` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `peminjaman`
--

INSERT INTO `peminjaman` (`id_peminjaman`, `keterangan_peminjaman`, `tgl_peminjaman`, `tgl_pengembalian`, `id_barang`) VALUES
(1, 'Diaz 1AEC4 - Penggunaan Praktikum Prosman', '2023-12-29', '2023-11-15', 1),
(2, 'Bayu 1AEC4 - Peminjaman sementara praktikum', '2023-12-29', '2023-11-15', 3);

--
-- Triggers `peminjaman`
--
DELIMITER $$
CREATE TRIGGER `after_delete_peminjaman` AFTER DELETE ON `peminjaman` FOR EACH ROW BEGIN
    DECLARE jumlah_barang INT;
    SELECT jumlah_barang INTO jumlah_barang FROM barang WHERE id_barang = OLD.id_barang;
    SET jumlah_barang = jumlah_barang + 1;
    UPDATE barang
    SET jumlah_barang = jumlah_barang
    WHERE id_barang = OLD.id_barang;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_insert_peminjaman` AFTER INSERT ON `peminjaman` FOR EACH ROW BEGIN
    DECLARE barang_count INT;
    SELECT jumlah_barang INTO barang_count
    FROM barang
    WHERE id_barang = NEW.id_barang;
    UPDATE barang
    SET jumlah_barang = barang_count - 1
    WHERE id_barang = NEW.id_barang;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id_user` int NOT NULL,
  `role` varchar(100) DEFAULT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `role`, `username`, `password`) VALUES
(1, 'Admin', 'Admin', 'Admin'),
(2, 'Mahasiswa', '223443077', 'polmanbandung');

--
-- Triggers `user`
--
DELIMITER $$
CREATE TRIGGER `before_insert_update_user` BEFORE INSERT ON `user` FOR EACH ROW BEGIN
    DECLARE existing_user_count INT;
    SELECT COUNT(*) INTO existing_user_count FROM user WHERE username = NEW.username;
    IF existing_user_count > 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Username already exists';
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Stand-in structure for view `view_laporan`
-- (See below for the actual view)
--
CREATE TABLE `view_laporan` (
`nama_barang` varchar(100)
,`kondisi_barang` varchar(100)
,`keterangan_inventaris` text
,`jumlah_dipemelihara` bigint
,`jumlah_dipinjam` bigint
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `view_notifikasi`
-- (See below for the actual view)
--
CREATE TABLE `view_notifikasi` (
`nama_barang` varchar(100)
,`keterangan` varchar(12)
,`tanggal` date
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `view_status`
-- (See below for the actual view)
--
CREATE TABLE `view_status` (
`id_barang` int
,`nama_barang` varchar(100)
,`jumlah_barang` int
,`merk` varchar(100)
,`status` varchar(125)
);

-- --------------------------------------------------------

--
-- Structure for view `view_laporan`
--
DROP TABLE IF EXISTS `view_laporan`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_laporan`  AS SELECT `db`.`nama_barang` AS `nama_barang`, `inv`.`kondisi_barang` AS `kondisi_barang`, `inv`.`keterangan_inventaris` AS `keterangan_inventaris`, count(distinct `pem`.`id_pemeliharaan`) AS `jumlah_dipemelihara`, count(distinct `p`.`id_peminjaman`) AS `jumlah_dipinjam` FROM (((`barang` `db` left join `inventaris` `inv` on((`db`.`id_barang` = `inv`.`id_barang`))) left join `pemeliharaan` `pem` on((`db`.`id_barang` = `pem`.`id_barang`))) left join `peminjaman` `p` on((`db`.`id_barang` = `p`.`id_barang`))) GROUP BY `db`.`nama_barang`, `inv`.`kondisi_barang`, `inv`.`keterangan_inventaris``keterangan_inventaris`  ;

-- --------------------------------------------------------

--
-- Structure for view `view_notifikasi`
--
DROP TABLE IF EXISTS `view_notifikasi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_notifikasi`  AS SELECT `db`.`nama_barang` AS `nama_barang`, 'Pemeliharaan' AS `keterangan`, curdate() AS `tanggal` FROM (`barang` `db` join `pemeliharaan` `pem` on((`db`.`id_barang` = `pem`.`id_barang`))) union select `db`.`nama_barang` AS `nama_barang`,'Peminjaman' AS `keterangan`,curdate() AS `tanggal` from `barang` `db` where (`db`.`jumlah_barang` = 0)  ;

-- --------------------------------------------------------

--
-- Structure for view `view_status`
--
DROP TABLE IF EXISTS `view_status`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_status`  AS SELECT `db`.`id_barang` AS `id_barang`, `db`.`nama_barang` AS `nama_barang`, `db`.`jumlah_barang` AS `jumlah_barang`, `db`.`merk` AS `merk`, concat('Tersedia (',`db`.`jumlah_barang`,'), ','Dipinjam (',count(distinct `p`.`id_peminjaman`),'), ','Dipelihara (',count(distinct `pem`.`id_pemeliharaan`),')',' - Total: ',((`db`.`jumlah_barang` + count(distinct `p`.`id_peminjaman`)) + count(distinct `pem`.`id_pemeliharaan`))) AS `status` FROM ((`barang` `db` left join `peminjaman` `p` on((`db`.`id_barang` = `p`.`id_barang`))) left join `pemeliharaan` `pem` on((`db`.`id_barang` = `pem`.`id_barang`))) GROUP BY `db`.`id_barang`, `db`.`nama_barang`, `db`.`jumlah_barang`, `db`.`merk``merk`  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id_barang`),
  ADD KEY `id_lokasi` (`id_lokasi`);

--
-- Indexes for table `inventaris`
--
ALTER TABLE `inventaris`
  ADD PRIMARY KEY (`id_inventaris`),
  ADD KEY `id_barang` (`id_barang`);

--
-- Indexes for table `lokasi`
--
ALTER TABLE `lokasi`
  ADD PRIMARY KEY (`id_lokasi`);

--
-- Indexes for table `pemeliharaan`
--
ALTER TABLE `pemeliharaan`
  ADD PRIMARY KEY (`id_pemeliharaan`),
  ADD KEY `id_barang` (`id_barang`);

--
-- Indexes for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD PRIMARY KEY (`id_peminjaman`),
  ADD KEY `id_barang` (`id_barang`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `id_barang` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `inventaris`
--
ALTER TABLE `inventaris`
  MODIFY `id_inventaris` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `lokasi`
--
ALTER TABLE `lokasi`
  MODIFY `id_lokasi` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `pemeliharaan`
--
ALTER TABLE `pemeliharaan`
  MODIFY `id_pemeliharaan` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `peminjaman`
--
ALTER TABLE `peminjaman`
  MODIFY `id_peminjaman` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `barang`
--
ALTER TABLE `barang`
  ADD CONSTRAINT `barang_ibfk_1` FOREIGN KEY (`id_lokasi`) REFERENCES `lokasi` (`id_lokasi`);

--
-- Constraints for table `inventaris`
--
ALTER TABLE `inventaris`
  ADD CONSTRAINT `inventaris_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`);

--
-- Constraints for table `pemeliharaan`
--
ALTER TABLE `pemeliharaan`
  ADD CONSTRAINT `pemeliharaan_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`);

--
-- Constraints for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD CONSTRAINT `peminjaman_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

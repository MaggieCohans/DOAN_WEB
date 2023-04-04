let thoi_gian = 10;
let diem = 0;
let dang_choi;
const chu_duoc_nhap = document.querySelector('#chu_duoc_nhap');
const chu_hien_tai = document.querySelector('#chu_hien_tai');
const diem_hien_thi = document.querySelector('#diem');
const thoi_gian_hien_thi = document.querySelector('#giay');
const thong_bao = document.querySelector('#thong_bao');
const chu = [
    '教師',
    '愛',
    '学生',
    '失礼',
    '悲しい',
    '別れる',
    'さようなら',
    'よむ',
    '泣く',
    'ともだち',
    '好きだよ',
    'たばこ',
    '学ぶ',
    '学校',
    'ならう',
    'せかい',
    'しゃかい',
    'うたう',
    '終わり',
    'きく',
    '情報',
    'たな',
    'ありがとう',
    '店',
    '問題'
];


window.addEventListener('load', chay_ham);

function hien_thi_chu(chu) {
    const chu_ngau_nhien = Math.floor(Math.random() * chu.length);
    chu_hien_tai.innerHTML = chu[chu_ngau_nhien];
}

function dem_nguoc() {
    if (thoi_gian > 0) {
        thoi_gian--;
    } else if (thoi_gian == 0) {
        dang_choi = false;
    }
    thoi_gian_hien_thi.innerHTML = thoi_gian;
}


function so_sanh_chu() {
    if (so_sanh_tu()) {
        dang_choi = true;
        thoi_gian = 10;
        hien_thi_chu(chu);
        chu_duoc_nhap.value = '';
        diem++;
    }
    diem_hien_thi.innerHTML = diem;
}
function so_sanh_tu() {
    if ((chu_duoc_nhap.value) === (chu_hien_tai.innerHTML)) {
        thong_bao.innerHTML = 'Đúng Rồi';
        return true;
    } else {
        thong_bao.innerHTML = '';
        return false;
    }
}

function kiem_tra_chu() {
    if (!dang_choi && thoi_gian === 0) {
        thong_bao.innerHTML = 'Trò Chơi Kết Thúc!';
        diem = 0;
    }
}

function chay_ham() {
    hien_thi_chu(chu);
    chu_duoc_nhap.addEventListener('input', so_sanh_chu)
    setInterval(dem_nguoc, 1000);
    setInterval(kiem_tra_chu, 50);
}

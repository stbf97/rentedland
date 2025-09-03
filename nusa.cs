background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), 
            url('https://png.pngtree.com/thumb_back/fw800/background/20240715/pngtree-leaves-of-banana-abstract-green-dark-texture-nature-background-tropical-leaf-image_16003764.jpg') center/cover no-repeat;
body {
  margin: 0;
  font-family: 'Open Sans', sans-serif;
  background: linear-gradient(135deg, #fff8f0 0%, #ffe8d9 50%, #f5e0d0 100%);
  background-attachment: fixed;
  color: var(--text);
  line-height: 1.6;
  overflow-x: hidden;
}
.cta {
  background: linear-gradient(135deg, var(--secondary), #b28d58);
  color: var(--light);
  text-align: center;
  padding: 3rem 1.5rem;
  border-radius: var(--border-radius);
  box-shadow: var(--shadow);
}

body {
  margin: 0;
  font-family: 'Open Sans', sans-serif;
  background: linear-gradient(120deg, #f6d365 0%, #fda085 50%, #fbc2eb 100%);
  color: var(--text);
  line-height: 1.6;
  overflow-x: hidden;
}

/* Map Image Container */
.map-image-container {
  width: 100%;
  max-width: 800px;
  margin: 0 auto;
  border-radius: var(--border-radius);
  overflow: hidden;
  box-shadow: var(--shadow);
  border: 1px solid rgba(0,0,0,0.1);
}

.map-image {
  width: 100%;
  height: auto;
  display: block;
  transition: var(--transition);
}

.map-image:hover {
  transform: scale(1.02);
}

/* Translator Button Styles */
.translator-container {
  position: fixed;
  top: 20px;
  right: 20px;
  z-index: 9999;
  font-family: 'Open Sans', sans-serif;
}

.translator-btn {
  background: white;
  border: 1px solid #ccc;
  padding: 8px 14px;
  border-radius: 50px;
  font-size: 14px;
  cursor: pointer;
  display: flex;
  align-items: center;
  gap: 8px;
  box-shadow: 0 2px 6px rgba(0,0,0,0.15);
}

.language-dropdown {
  position: absolute;
  top: 100%;
  right: 0;
  background: white;
  border: 1px solid #ccc;
  border-radius: 8px;
  box-shadow: 0 5px 15px rgba(0,0,0,0.15);
  margin-top: 8px;
  display: none;
  flex-direction: column;
  overflow: hidden;
}

.translator-container:hover .language-dropdown {
  display: flex;
}

.language-option {
  padding: 10px;
  display: flex;
  align-items: center;
  gap: 8px;
  cursor: pointer;
  transition: background 0.3s;
}

.language-option:hover {
  background-color: #f2f2f2;
}

.language-option img {
  width: 20px;
  height: 15px;
  object-fit: cover;
  border-radius: 2px;
}
